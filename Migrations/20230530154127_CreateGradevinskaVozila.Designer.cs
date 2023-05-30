﻿// <auto-generated />
using Machine_arts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Machine_arts.Migrations
{
    [DbContext(typeof(MachineArtsContext))]
    [Migration("20230530154127_CreateGradevinskaVozila")]
    partial class CreateGradevinskaVozila
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Machine_arts.Models.Bager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Bager");
                });

            modelBuilder.Entity("Machine_arts.Models.Buldozer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Buldozer");
                });

            modelBuilder.Entity("Machine_arts.Models.Demper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Demper");
                });

            modelBuilder.Entity("Machine_arts.Models.GradevinskiStroj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GradevinskiStroj");
                });

            modelBuilder.Entity("Machine_arts.Models.GradevinskoVozilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GradevinskoVozilo");
                });

            modelBuilder.Entity("Machine_arts.Models.Kiper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kiper");
                });

            modelBuilder.Entity("Machine_arts.Models.Kombinirka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kombinirka");
                });

            modelBuilder.Entity("Machine_arts.Models.KranDizalica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KranDizalica");
                });

            modelBuilder.Entity("Machine_arts.Models.Mikser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Mikser");
                });

            modelBuilder.Entity("Machine_arts.Models.Tegljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tegljac");
                });

            modelBuilder.Entity("Machine_arts.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Machine_arts.Models.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginPassword")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Machine_arts.Models.Utovarivac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Utovarivac");
                });

            modelBuilder.Entity("Machine_arts.Models.Valjak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cijena")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specifikacije")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Valjak");
                });
#pragma warning restore 612, 618
        }
    }
}
