﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presistence;

namespace Presistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210618081057_BloodDonor")]
    partial class BloodDonor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Domain.BloodDonor", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastDonation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("BloodDonors");
                });

            modelBuilder.Entity("Domain.Department", b =>
                {
                    b.Property<Guid>("Department_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Department_id");

                    b.ToTable("Departmentet");
                });

            modelBuilder.Entity("Domain.Fatura", b =>
                {
                    b.Property<Guid>("Fatura_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("KrijuarMe")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Pacient_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("TEXT");

                    b.Property<int>("Shuma")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Statusi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulli")
                        .HasColumnType("TEXT");

                    b.HasKey("Fatura_Id");

                    b.HasIndex("Pacient_id");

                    b.ToTable("Faturat");
                });

            modelBuilder.Entity("Domain.Infermierja", b =>
                {
                    b.Property<Guid>("Infermierja_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Departamenti")
                        .HasColumnType("TEXT");

                    b.Property<string>("Emri")
                        .HasColumnType("TEXT");

                    b.Property<int>("Koeficienti")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("TEXT");

                    b.HasKey("Infermierja_Id");

                    b.ToTable("Infermieret");
                });

            modelBuilder.Entity("Domain.Mjeku", b =>
                {
                    b.Property<Guid>("Mjeku_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ditlindja")
                        .HasColumnType("TEXT");

                    b.Property<string>("Emri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mbimeri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specializimi")
                        .HasColumnType("TEXT");

                    b.Property<string>("depName")
                        .HasColumnType("TEXT");

                    b.HasKey("Mjeku_Id");

                    b.ToTable("Mjeket");
                });

            modelBuilder.Entity("Domain.Pacient", b =>
                {
                    b.Property<Guid>("Pacient_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("adresa")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ditlindja")
                        .HasColumnType("TEXT");

                    b.Property<string>("emri")
                        .HasColumnType("TEXT");

                    b.Property<string>("grupigjakut")
                        .HasColumnType("TEXT");

                    b.Property<string>("mbimeri")
                        .HasColumnType("TEXT");

                    b.Property<string>("qyteti")
                        .HasColumnType("TEXT");

                    b.HasKey("Pacient_Id");

                    b.ToTable("pacientet");
                });

            modelBuilder.Entity("Domain.prov", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("prova2")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("prova");
                });

            modelBuilder.Entity("Domain.Fatura", b =>
                {
                    b.HasOne("Domain.Pacient", "Pacient")
                        .WithMany()
                        .HasForeignKey("Pacient_id")
                        .HasConstraintName("FK_Fatura_Pacient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
