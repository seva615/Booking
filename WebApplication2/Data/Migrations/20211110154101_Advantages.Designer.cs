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
    [Migration("20211110154101_Advantages")]
    partial class Advantages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Booking.Data.AdvantageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdvantageName")
                        .HasColumnType("text");

                    b.Property<string>("AdvantageType")
                        .HasColumnType("text");

                    b.Property<Guid?>("RoomEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoomEntityId");

                    b.ToTable("Advantages");
                });

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

                    b.Property<Guid>("CityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("HotelName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Booking.Data.RoomEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AdvantageId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("HotelEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uuid");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("integer");

                    b.Property<int>("RoomSpace")
                        .HasColumnType("integer");

                    b.Property<string>("RoomType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HotelEntityId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking.Data.AdvantageEntity", b =>
                {
                    b.HasOne("Booking.Data.RoomEntity", null)
                        .WithMany("Advantages")
                        .HasForeignKey("RoomEntityId");
                });

            modelBuilder.Entity("Booking.Data.CityEntity", b =>
                {
                    b.HasOne("Booking.Data.ContryEntity", null)
                        .WithMany("Cities")
                        .HasForeignKey("ContryEntityId");
                });

            modelBuilder.Entity("Booking.Data.HotelEntity", b =>
                {
                    b.HasOne("Booking.Data.CityEntity", "city")
                        .WithMany("Hotels")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("city");
                });

            modelBuilder.Entity("Booking.Data.RoomEntity", b =>
                {
                    b.HasOne("Booking.Data.HotelEntity", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelEntityId");
                });

            modelBuilder.Entity("Booking.Data.CityEntity", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("Booking.Data.ContryEntity", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Booking.Data.HotelEntity", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Booking.Data.RoomEntity", b =>
                {
                    b.Navigation("Advantages");
                });
#pragma warning restore 612, 618
        }
    }
}
