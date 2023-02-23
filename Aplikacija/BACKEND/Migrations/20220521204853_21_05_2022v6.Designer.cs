﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace New_folder.Migrations
{
    [DbContext(typeof(LoveCookingContext))]
    [Migration("20220521204853_21_05_2022v6")]
    partial class _21_05_2022v6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KorisnikUcestvovanje", b =>
                {
                    b.Property<int>("GlasanjaID")
                        .HasColumnType("int");

                    b.Property<int>("GlasanjaID1")
                        .HasColumnType("int");

                    b.HasKey("GlasanjaID", "GlasanjaID1");

                    b.HasIndex("GlasanjaID1");

                    b.ToTable("KorisnikUcestvovanje");
                });

            modelBuilder.Entity("Models.Jelo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("MeniID")
                        .HasColumnType("int");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.Property<int>("TipJela")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MeniID");

                    b.HasIndex("ReceptID");

                    b.ToTable("Jelo");
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("Ocena")
                        .HasColumnType("int");

                    b.Property<bool?>("Prijava")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ReceptID");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("Models.Korak", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BrojKoraka")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.Property<int?>("SlikeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReceptID");

                    b.HasIndex("SlikeID");

                    b.ToTable("Korak");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BrojTelefona")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("Ime")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("KonformacioniBroj")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Prezime")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("ProfilaSlikaID")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ProfilaSlikaID");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.Meni", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumPostavljanja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Kalorije")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Opis")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Prijava")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Meni");
                });

            modelBuilder.Entity("Models.Pice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Cena")
                        .HasColumnType("int");

                    b.Property<int?>("Kalorije")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("ProcenatAlkohola")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Pice");
                });

            modelBuilder.Entity("Models.Prati", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("PracenikID")
                        .HasColumnType("int");

                    b.Property<int?>("PratiocID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PracenikID");

                    b.HasIndex("PratiocID");

                    b.ToTable("Prati");
                });

            modelBuilder.Entity("Models.Recept", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("BrojPorcija")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Cena")
                        .HasColumnType("int");

                    b.Property<bool?>("DaLiJeDodatNaSlajd")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Kalorije")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Opis")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("OriginalniReceptID")
                        .HasColumnType("int");

                    b.Property<int?>("PiceID")
                        .HasColumnType("int");

                    b.Property<bool?>("Prijava")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<int>("TipRecepta")
                        .HasColumnType("int");

                    b.Property<int?>("VremePripremeMinuti")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("OriginalniReceptID");

                    b.HasIndex("PiceID");

                    b.ToTable("Recept");
                });

            modelBuilder.Entity("Models.Sadrzi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.Property<int?>("SastojciID")
                        .HasColumnType("int");

                    b.Property<int>("TipJedinice")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReceptID");

                    b.HasIndex("SastojciID");

                    b.ToTable("Sadrzi");
                });

            modelBuilder.Entity("Models.Sastojak", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Cena")
                        .HasColumnType("int");

                    b.Property<int?>("Kalorije")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Odobren")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Sastojak");
                });

            modelBuilder.Entity("Models.Slika", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Path")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Prijava")
                        .HasColumnType("bit");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReceptID");

                    b.ToTable("Slika");
                });

            modelBuilder.Entity("Models.Takmicenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumDo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumOd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Opis")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("Takmicenje");
                });

            modelBuilder.Entity("Models.Ucestvovanje", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"), 1L, 1);

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.Property<int?>("TakmicenjeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReceptID");

                    b.HasIndex("TakmicenjeID");

                    b.ToTable("Ucestvovanje");
                });

            modelBuilder.Entity("KorisnikUcestvovanje", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("GlasanjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Ucestvovanje", null)
                        .WithMany()
                        .HasForeignKey("GlasanjaID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Jelo", b =>
                {
                    b.HasOne("Models.Meni", "Meni")
                        .WithMany("Jela")
                        .HasForeignKey("MeniID");

                    b.HasOne("Models.Recept", "Recept")
                        .WithMany("Jela")
                        .HasForeignKey("ReceptID");

                    b.Navigation("Meni");

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Komentari")
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Recept", "Recept")
                        .WithMany("Komentari")
                        .HasForeignKey("ReceptID");

                    b.Navigation("Korisnik");

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("Models.Korak", b =>
                {
                    b.HasOne("Models.Recept", "Recept")
                        .WithMany("Koraci")
                        .HasForeignKey("ReceptID");

                    b.HasOne("Models.Slika", "Slike")
                        .WithMany()
                        .HasForeignKey("SlikeID");

                    b.Navigation("Recept");

                    b.Navigation("Slike");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.HasOne("Models.Slika", "ProfilaSlika")
                        .WithMany()
                        .HasForeignKey("ProfilaSlikaID");

                    b.Navigation("ProfilaSlika");
                });

            modelBuilder.Entity("Models.Meni", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Meniji")
                        .HasForeignKey("KorisnikID");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.Prati", b =>
                {
                    b.HasOne("Models.Korisnik", "Pracenik")
                        .WithMany("Pratioci")
                        .HasForeignKey("PracenikID");

                    b.HasOne("Models.Korisnik", "Pratioc")
                        .WithMany("Prati")
                        .HasForeignKey("PratiocID");

                    b.Navigation("Pracenik");

                    b.Navigation("Pratioc");
                });

            modelBuilder.Entity("Models.Recept", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.HasOne("Models.Recept", "OriginalniRecept")
                        .WithMany()
                        .HasForeignKey("OriginalniReceptID");

                    b.HasOne("Models.Pice", "Pice")
                        .WithMany("Recepti")
                        .HasForeignKey("PiceID");

                    b.Navigation("Korisnik");

                    b.Navigation("OriginalniRecept");

                    b.Navigation("Pice");
                });

            modelBuilder.Entity("Models.Sadrzi", b =>
                {
                    b.HasOne("Models.Recept", "Recept")
                        .WithMany("SadrziSastojke")
                        .HasForeignKey("ReceptID");

                    b.HasOne("Models.Sastojak", "Sastojci")
                        .WithMany("SastojakSadrzi")
                        .HasForeignKey("SastojciID");

                    b.Navigation("Recept");

                    b.Navigation("Sastojci");
                });

            modelBuilder.Entity("Models.Slika", b =>
                {
                    b.HasOne("Models.Recept", null)
                        .WithMany("Slike")
                        .HasForeignKey("ReceptID");
                });

            modelBuilder.Entity("Models.Ucestvovanje", b =>
                {
                    b.HasOne("Models.Recept", "Recept")
                        .WithMany("Ucestvovanja")
                        .HasForeignKey("ReceptID");

                    b.HasOne("Models.Takmicenje", "Takmicenje")
                        .WithMany("Ucestvovanja")
                        .HasForeignKey("TakmicenjeID");

                    b.Navigation("Recept");

                    b.Navigation("Takmicenje");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("Komentari");

                    b.Navigation("Meniji");

                    b.Navigation("Prati");

                    b.Navigation("Pratioci");
                });

            modelBuilder.Entity("Models.Meni", b =>
                {
                    b.Navigation("Jela");
                });

            modelBuilder.Entity("Models.Pice", b =>
                {
                    b.Navigation("Recepti");
                });

            modelBuilder.Entity("Models.Recept", b =>
                {
                    b.Navigation("Jela");

                    b.Navigation("Komentari");

                    b.Navigation("Koraci");

                    b.Navigation("SadrziSastojke");

                    b.Navigation("Slike");

                    b.Navigation("Ucestvovanja");
                });

            modelBuilder.Entity("Models.Sastojak", b =>
                {
                    b.Navigation("SastojakSadrzi");
                });

            modelBuilder.Entity("Models.Takmicenje", b =>
                {
                    b.Navigation("Ucestvovanja");
                });
#pragma warning restore 612, 618
        }
    }
}