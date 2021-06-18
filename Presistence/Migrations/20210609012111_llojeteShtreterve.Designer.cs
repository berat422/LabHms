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
    [Migration("20210609012111_llojeteShtreterve")]
    partial class llojeteShtreterve
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Domain.Barna", b =>
                {
                    b.Property<Guid>("Barnat_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataRegjistrimit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Barnat_Id");

                    b.ToTable("Barnat");
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

            modelBuilder.Entity("Domain.Laboratori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Emri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mosha")
                        .HasColumnType("TEXT");

                    b.Property<string>("NrId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rezultati")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Laboratoret");
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

                    b.Property<DateTime?>("ditlindja")
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

            modelBuilder.Entity("Domain.Shtrat", b =>
                {
                    b.Property<Guid>("Shtrat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Statusi")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("llojiShtratit_id")
                        .HasColumnType("TEXT");

                    b.Property<int>("nrShtratit")
                        .HasColumnType("INTEGER");

                    b.HasKey("Shtrat_id");

                    b.HasIndex("llojiShtratit_id");

                    b.ToTable("Shtreter");
                });

            modelBuilder.Entity("Domain.Therapy", b =>
                {
                    b.Property<Guid>("Therapy_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("OnGoing")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Pacient_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("terapia")
                        .HasColumnType("TEXT");

                    b.HasKey("Therapy_Id");

                    b.HasIndex("Pacient_id");

                    b.ToTable("Therapies");
                });

            modelBuilder.Entity("Domain.llojiShtratit", b =>
                {
                    b.Property<Guid>("llojiShtratit_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("emri")
                        .HasColumnType("TEXT");

                    b.HasKey("llojiShtratit_id");

                    b.ToTable("llojeteShtreterve");
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

            modelBuilder.Entity("Domain.Shtrat", b =>
                {
                    b.HasOne("Domain.llojiShtratit", "llojiShtratit")
                        .WithMany()
                        .HasForeignKey("llojiShtratit_id")
                        .HasConstraintName("FK_Shtrat_llojiShtratit_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Therapy", b =>
                {
                    b.HasOne("Domain.Pacient", "Pacient")
                        .WithMany()
                        .HasForeignKey("Pacient_id")
                        .HasConstraintName("FK_Therapy_Pacient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
