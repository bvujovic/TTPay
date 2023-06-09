﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TTPay.Models.Data;

#nullable disable

namespace TTPay.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230404155613_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("TTPay.Models.Susret", b =>
                {
                    b.Property<int>("SusretId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BojanPlatio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BojanPotrosio")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int>("ManicPlatio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManicPotrosio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ZecPlatio")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ZecPotrosio")
                        .HasColumnType("INTEGER");

                    b.HasKey("SusretId");

                    b.ToTable("Susreti");
                });
#pragma warning restore 612, 618
        }
    }
}
