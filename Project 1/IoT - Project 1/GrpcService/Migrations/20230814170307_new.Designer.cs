﻿// <auto-generated />
using System;
using GrpcService.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GrpcService.Migrations
{
    [DbContext(typeof(AirPiDbContext))]
    [Migration("20230814170307_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GrpcService.Repository.AirPiValue", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("AirQuality")
                        .HasColumnType("float");

                    b.Property<double>("CarbonMonoxide")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("LightLevel")
                        .HasColumnType("float");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<double>("NitrogenDioxide")
                        .HasColumnType("float");

                    b.Property<double>("Pressure")
                        .HasColumnType("float");

                    b.Property<double>("RelativeHumidity")
                        .HasColumnType("float");

                    b.Property<double>("TemperatureBMP")
                        .HasColumnType("float");

                    b.Property<double>("TemperatureDHT")
                        .HasColumnType("float");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("AirPiValues");
                });
#pragma warning restore 612, 618
        }
    }
}
