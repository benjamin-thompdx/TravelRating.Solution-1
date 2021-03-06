﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelRating.Models;

namespace TravelRating.Migrations
{
    [DbContext(typeof(TravelRatingContext))]
    partial class TravelRatingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelRating.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("LocationId");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.HasKey("ExperienceId");

                    b.HasIndex("LocationId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            ExperienceId = 1,
                            Author = "Ben's Mom",
                            LocationId = 3,
                            Rating = 2,
                            Review = "Hanoi"
                        },
                        new
                        {
                            ExperienceId = 2,
                            Author = "Matt's Mom",
                            LocationId = 3,
                            Rating = 2,
                            Review = "Reykjavik"
                        },
                        new
                        {
                            ExperienceId = 3,
                            Author = "Katy's Mom",
                            LocationId = 3,
                            Rating = 2,
                            Review = "Kerry"
                        },
                        new
                        {
                            ExperienceId = 4,
                            Author = "Katy's Kids' Mom",
                            LocationId = 3,
                            Rating = 2,
                            Review = "New York"
                        });
                });

            modelBuilder.Entity("TravelRating.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            City = "Hanoi",
                            Country = "Vietnam",
                            Name = "Ha Long Bay"
                        },
                        new
                        {
                            LocationId = 2,
                            City = "Reykjavik",
                            Country = "Iceland",
                            Name = "Thingvellir Park"
                        },
                        new
                        {
                            LocationId = 3,
                            City = "Kerry",
                            Country = "Ireland",
                            Name = "Killarney National Park"
                        },
                        new
                        {
                            LocationId = 4,
                            City = "New York",
                            Country = "United States",
                            Name = "Clock Walk"
                        });
                });

            modelBuilder.Entity("TravelRating.Models.Experience", b =>
                {
                    b.HasOne("TravelRating.Models.Location")
                        .WithMany("Experiences")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
