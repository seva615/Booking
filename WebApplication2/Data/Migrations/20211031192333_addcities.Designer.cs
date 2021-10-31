﻿// <auto-generated />
using System;
using Booking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Booking.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211031192333_addcities")]
    partial class addcities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Booking.Data.CityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CityName")
                        .HasColumnType("text");

                    b.Property<Guid?>("ContryEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ContryId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContryEntityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Booking.Data.ContryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ContryName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contries");
                });

            modelBuilder.Entity("Booking.Data.HotelEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<string>("Advantage")
                        .HasColumnType("text");

                    b.Property<Guid?>("CityEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<string>("HotelName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityEntityId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Booking.Data.CityEntity", b =>
                {
                    b.HasOne("Booking.Data.ContryEntity", null)
                        .WithMany("Cities")
                        .HasForeignKey("ContryEntityId");
                });

            modelBuilder.Entity("Booking.Data.HotelEntity", b =>
                {
                    b.HasOne("Booking.Data.CityEntity", null)
                        .WithMany("Hotels")
                        .HasForeignKey("CityEntityId");
                });

            modelBuilder.Entity("Booking.Data.CityEntity", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("Booking.Data.ContryEntity", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
