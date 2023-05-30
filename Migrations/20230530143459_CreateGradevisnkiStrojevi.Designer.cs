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
    [Migration("20230530143459_CreateGradevisnkiStrojevi")]
    partial class CreateGradevisnkiStrojevi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

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
#pragma warning restore 612, 618
        }
    }
}
