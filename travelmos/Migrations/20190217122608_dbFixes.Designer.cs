﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using travelmos.EF;

namespace travelmos.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190217122608_dbFixes")]
    partial class dbFixes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("travelmos.EntityModels.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OfferId");

                    b.Property<int>("ReservedSeats");

                    b.Property<int>("TouristId");

                    b.HasKey("BookingId");

                    b.HasIndex("OfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("travelmos.EntityModels.Guide", b =>
                {
                    b.Property<int>("GuideId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("OfferId");

                    b.Property<int>("PrimaryLanguageId");

                    b.Property<int>("SecondaryLanguageId");

                    b.HasKey("GuideId");

                    b.HasIndex("OfferId");

                    b.HasIndex("PrimaryLanguageId");

                    b.HasIndex("SecondaryLanguageId");

                    b.ToTable("Guide");
                });

            modelBuilder.Entity("travelmos.EntityModels.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("LanguageId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("travelmos.EntityModels.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromTime");

                    b.Property<bool>("IncludedTransport");

                    b.Property<string>("Location");

                    b.Property<int>("Seats");

                    b.HasKey("OfferId");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("travelmos.EntityModels.Tourist", b =>
                {
                    b.Property<int>("TouristId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("PrimaryLanguageId");

                    b.Property<int>("SecondaryLanguageId");

                    b.HasKey("TouristId");

                    b.HasIndex("PrimaryLanguageId");

                    b.HasIndex("SecondaryLanguageId");

                    b.ToTable("Tourist");
                });

            modelBuilder.Entity("travelmos.EntityModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("UserUserTypeId");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("UserUserTypeId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("travelmos.EntityModels.UserUserType", b =>
                {
                    b.Property<int>("UserUserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GuideId");

                    b.Property<int>("TouristId");

                    b.HasKey("UserUserTypeId");

                    b.HasIndex("GuideId");

                    b.HasIndex("TouristId");

                    b.ToTable("UserUserType");
                });

            modelBuilder.Entity("travelmos.EntityModels.Booking", b =>
                {
                    b.HasOne("travelmos.EntityModels.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelmos.EntityModels.Tourist", "Tourist")
                        .WithMany()
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travelmos.EntityModels.Guide", b =>
                {
                    b.HasOne("travelmos.EntityModels.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelmos.EntityModels.Language", "PrimaryLanguage")
                        .WithMany()
                        .HasForeignKey("PrimaryLanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelmos.EntityModels.Language", "SecondaryLanguage")
                        .WithMany()
                        .HasForeignKey("SecondaryLanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travelmos.EntityModels.Tourist", b =>
                {
                    b.HasOne("travelmos.EntityModels.Language", "PrimaryLanguage")
                        .WithMany()
                        .HasForeignKey("PrimaryLanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelmos.EntityModels.Language", "SecondaryLanguage")
                        .WithMany()
                        .HasForeignKey("SecondaryLanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travelmos.EntityModels.User", b =>
                {
                    b.HasOne("travelmos.EntityModels.UserUserType", "UserUserType")
                        .WithMany()
                        .HasForeignKey("UserUserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("travelmos.EntityModels.UserUserType", b =>
                {
                    b.HasOne("travelmos.EntityModels.Guide", "Guide")
                        .WithMany()
                        .HasForeignKey("GuideId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("travelmos.EntityModels.Tourist", "Tourist")
                        .WithMany()
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
