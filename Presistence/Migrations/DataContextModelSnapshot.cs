﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presistence;

namespace Presistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

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

            modelBuilder.Entity("Domain.Doktori", b =>
                {
                    b.Property<Guid>("Doktori_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Emri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Profile")
                        .HasColumnType("TEXT");

                    b.HasKey("Doktori_id");

                    b.ToTable("doktori");
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
#pragma warning restore 612, 618
        }
    }
}
