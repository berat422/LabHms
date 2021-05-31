using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Presistence;

namespace Application.Infermieret
{
    public class Create
    {
        public class Command : IRequest
        {
            public Infermierja Infermierja { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                this._context = context;

            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Infermieret.Add(request.Infermierja);

                await _context.SaveChangesAsync();
                
                return Unit.Value;
            }


        }
    }
}