﻿// <auto-generated />
using System;
using DemoForecastSC.Server.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DemoForecastSC.Server.Migrations
{
    [DbContext(typeof(ForecastDbContext))]
    partial class ForecastDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DemoForecastSC.Server.Models.LiveForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AirQuality")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("air-quality");

                    b.Property<string>("Celsius")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("celsius");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("Fahrenheit")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("fahrenheit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("summary");

                    b.Property<string>("Wind")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("wind");

                    b.HasKey("Id");

                    b.ToTable("live-forecast");
                });
#pragma warning restore 612, 618
        }
    }
}