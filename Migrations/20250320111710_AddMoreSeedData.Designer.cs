﻿// <auto-generated />
using System;
using EventEaseApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventEaseApp.Migrations
{
    [DbContext(typeof(EventEaseAppContext))]
    [Migration("20250320111710_AddMoreSeedData")]
    partial class AddMoreSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventEaseApp.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("EventId");

                    b.HasIndex("VenueId");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            BookingDate = new DateTime(2025, 3, 20, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            EventId = 1,
                            VenueId = 1
                        },
                        new
                        {
                            BookingId = 2,
                            BookingDate = new DateTime(2025, 3, 21, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            EventId = 2,
                            VenueId = 2
                        },
                        new
                        {
                            BookingId = 3,
                            BookingDate = new DateTime(2025, 3, 22, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            EventId = 3,
                            VenueId = 3
                        },
                        new
                        {
                            BookingId = 4,
                            BookingDate = new DateTime(2025, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            EventId = 4,
                            VenueId = 4
                        },
                        new
                        {
                            BookingId = 5,
                            BookingDate = new DateTime(2025, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            EventId = 5,
                            VenueId = 5
                        });
                });

            modelBuilder.Entity("EventEaseApp.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("EventId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            Description = "A global conference on emerging technologies.",
                            EventDate = new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Tech Conference 2025"
                        },
                        new
                        {
                            EventId = 2,
                            Description = "An electrifying music experience with top artists.",
                            EventDate = new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Music Festival 2025"
                        },
                        new
                        {
                            EventId = 3,
                            Description = "Latest trends and innovations in AI and ML.",
                            EventDate = new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "AI & Machine Learning Summit"
                        },
                        new
                        {
                            EventId = 4,
                            Description = "Networking with top entrepreneurs worldwide.",
                            EventDate = new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "International Business Expo"
                        },
                        new
                        {
                            EventId = 5,
                            Description = "A gathering for fans of comics, movies, and gaming.",
                            EventDate = new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventName = "Comic-Con 2025"
                        });
                });

            modelBuilder.Entity("EventEaseApp.Models.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VenueId");

                    b.ToTable("Venue");

                    b.HasData(
                        new
                        {
                            VenueId = 1,
                            Capacity = 500,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3f/Grand_Hall_Interior.jpg",
                            Location = "New York, USA",
                            VenueName = "Grand Hall"
                        },
                        new
                        {
                            VenueId = 2,
                            Capacity = 1000,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/89/Arena_in_LA.jpg",
                            Location = "Los Angeles, USA",
                            VenueName = "Sunset Arena"
                        },
                        new
                        {
                            VenueId = 3,
                            Capacity = 750,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/68/Modern_Pavilion.jpg",
                            Location = "Chicago, USA",
                            VenueName = "Skyline Pavilion"
                        },
                        new
                        {
                            VenueId = 4,
                            Capacity = 1200,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5a/Conference_Center.jpg",
                            Location = "London, UK",
                            VenueName = "Crystal Conference Center"
                        },
                        new
                        {
                            VenueId = 5,
                            Capacity = 2000,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/27/Modern_Stadium.jpg",
                            Location = "Miami, USA",
                            VenueName = "Blue Wave Stadium"
                        });
                });

            modelBuilder.Entity("EventEaseApp.Models.Booking", b =>
                {
                    b.HasOne("EventEaseApp.Models.Event", "Event")
                        .WithMany("Bookings")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventEaseApp.Models.Venue", "Venue")
                        .WithMany("Bookings")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("EventEaseApp.Models.Event", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("EventEaseApp.Models.Venue", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
