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

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

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

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.HasKey("Barnat_Id");

                    b.ToTable("Barnats");
                });

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

                    b.Property<string>("Fotografia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Department_id");

                    b.ToTable("Departmentet");
                });

            modelBuilder.Entity("Domain.Dhoma", b =>
                {
                    b.Property<Guid>("Dhoma_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("TEXT");

                    b.Property<string>("llojiDhomes")
                        .HasColumnType("TEXT");

                    b.Property<int>("nrDhomes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Dhoma_Id");

                    b.ToTable("Dhomat");
                });

            modelBuilder.Entity("Domain.Fatura", b =>
                {
                    b.Property<Guid>("Fatura_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("KrijuarMe")
                        .HasColumnType("TEXT");

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

<<<<<<< HEAD
            modelBuilder.Entity("Domain.Laboratori", b =>
                {
                    b.Property<Guid>("Lab_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Department_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Emri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fotografia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("TEXT");

                    b.HasKey("Lab_Id");

                    b.HasIndex("Department_id");

                    b.ToTable("Laboratoret");
                });

=======
>>>>>>> parent of ed8d6bc (Krijimi laboratorit front & back end)
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

            modelBuilder.Entity("Domain.Paisjet", b =>
                {
                    b.Property<Guid>("Paisja_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Department_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("emertimi")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .HasColumnType("TEXT");

                    b.Property<string>("pershkrimi")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("servisimi")
                        .HasColumnType("TEXT");

                    b.HasKey("Paisja_Id");

                    b.HasIndex("Department_Id");

                    b.ToTable("Paisjets");
                });

            modelBuilder.Entity("Domain.Provoprovo", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("emri")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("provoprovos");
                });

            modelBuilder.Entity("Domain.Raport", b =>
                {
                    b.Property<Guid>("Raport_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Paisja_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("raporti")
                        .HasColumnType("TEXT");

                    b.HasKey("Raport_Id");

                    b.HasIndex("Paisja_Id");

                    b.ToTable("Raportet");
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

            modelBuilder.Entity("Domain.ShtreteritNeDhome", b =>
                {
                    b.Property<Guid>("ShtreteritNeDhome_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Dhoma_Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Shtrat_Id")
                        .HasColumnType("TEXT");

                    b.HasKey("ShtreteritNeDhome_Id");

                    b.HasIndex("Dhoma_Id");

                    b.HasIndex("Shtrat_Id");

                    b.ToTable("ShtreteritNeDhome");
                });

            modelBuilder.Entity("Domain.Terminet", b =>
                {
                    b.Property<Guid>("termini_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Mjeku_Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Pacient_Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("orari")
                        .HasColumnType("TEXT");

                    b.HasKey("termini_ID");

                    b.HasIndex("Mjeku_Id");

                    b.HasIndex("Pacient_Id");

                    b.ToTable("Terminet");
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

            modelBuilder.Entity("Domain.caktoShtratin", b =>
                {
                    b.Property<Guid>("caktoShtratin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Pacient_id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Shtrat_id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("kohaHyrjes")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("kohaLeshimit")
                        .HasColumnType("TEXT");

                    b.HasKey("caktoShtratin_id");

                    b.HasIndex("Pacient_id");

                    b.HasIndex("Shtrat_id");

                    b.ToTable("caktoShtreterit");
                });

            modelBuilder.Entity("Domain.llojiShtratit", b =>
                {
                    b.Property<Guid>("llojiShtratit_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pershkrimi")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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

            modelBuilder.Entity("Domain.Laboratori", b =>
                {
                    b.HasOne("Domain.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_id")
                        .HasConstraintName("FK_Laboratori_Department_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Paisjet", b =>
                {
                    b.HasOne("Domain.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Raport", b =>
                {
                    b.HasOne("Domain.Paisjet", "Paisjet")
                        .WithMany()
                        .HasForeignKey("Paisja_Id")
                        .HasConstraintName("FK_Raport_Paisja_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Domain.ShtreteritNeDhome", b =>
                {
                    b.HasOne("Domain.Dhoma", "Dhoma")
                        .WithMany()
                        .HasForeignKey("Dhoma_Id")
                        .HasConstraintName("FK_ShtreteritNeDhome_Dhoma_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Shtrat", "Shtrat")
                        .WithMany()
                        .HasForeignKey("Shtrat_Id")
                        .HasConstraintName("FK_ShtreteritNeDhome_Shtrat_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Terminet", b =>
                {
                    b.HasOne("Domain.Mjeku", "mjeket")
                        .WithMany()
                        .HasForeignKey("Mjeku_Id")
                        .HasConstraintName("FK_Terminat_Doktoret")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Pacient", "pacient")
                        .WithMany()
                        .HasForeignKey("Pacient_Id")
                        .HasConstraintName("FK_Temrinet_Pacinetat")
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

            modelBuilder.Entity("Domain.caktoShtratin", b =>
                {
                    b.HasOne("Domain.Pacient", "Pacient")
                        .WithMany()
                        .HasForeignKey("Pacient_id")
                        .HasConstraintName("FK_caktoShtratin_Pacient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Shtrat", "Shtrat")
                        .WithMany()
                        .HasForeignKey("Shtrat_id")
                        .HasConstraintName("FK_caktoShtratin_Shtrat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
