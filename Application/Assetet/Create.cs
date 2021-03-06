using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using MediatR;
using Domain;
using Presistence;
using FluentValidation;

namespace Application.Assetet
{
    public class Create
    {
         public class Command : IRequest<Result<Unit>>
        { 
            public Paisjet paisje { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.paisje).SetValidator(new PaisjetValidator());
            }
        }



        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Paisjets.Add(request.paisje);

                var result = await _context.SaveChangesAsync() > 0;

                if (!result) return Result<Unit>.Failure("Operacioni deshtoi");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}