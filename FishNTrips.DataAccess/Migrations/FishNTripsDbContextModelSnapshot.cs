﻿// <auto-generated />
using System;
using FishNTrips.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FishNTrips.DataAccess.Migrations
{
    [DbContext(typeof(FishNTripsDbContext))]
    partial class FishNTripsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FishNTrips.Model.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocationId");

                    b.Property<string>("MainComment")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FishNTrips.Model.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocationImgLocationId");

                    b.Property<string>("Url");

                    b.HasKey("ImageId");

                    b.HasIndex("LocationImgLocationId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("FishNTrips.Model.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("LocationCords");

                    b.Property<string>("LocationName");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("FishNTrips.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FishNTrips.Model.Comment", b =>
                {
                    b.HasOne("FishNTrips.Model.Location", "Location")
                        .WithMany("Comments")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FishNTrips.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FishNTrips.Model.Image", b =>
                {
                    b.HasOne("FishNTrips.Model.Location", "LocationImg")
                        .WithMany("ImageUrl")
                        .HasForeignKey("LocationImgLocationId");
                });
#pragma warning restore 612, 618
        }
    }
}
