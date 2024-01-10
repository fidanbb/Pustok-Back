﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pustok_Backend.Data;

#nullable disable

namespace Pustok_Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240110111016_addedNewDataToSettingTable")]
    partial class addedNewDataToSettingTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Pustok_Backend.Models.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Adverts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2395),
                            Image = "promo-banner-with-text.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2396)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2398),
                            Image = "promo-banner-with-text-2.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2399)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2400),
                            Header = "Buy 3. Get Free 1.",
                            Image = "promo-banner-mid.webp",
                            SoftDeleted = false,
                            Title = "50% off for selected products in Pustok.",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2401)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2403),
                            Header = "$26.00",
                            Image = "promo-banner-small.webp",
                            SoftDeleted = false,
                            Title = "Praise for The Night Child",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2404)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2406),
                            Header = "I Love This Idea!",
                            Image = "promo-banner-full.webp",
                            SoftDeleted = false,
                            Title = "Cover up front of book and leave summary",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2407)
                        });
                });

            modelBuilder.Entity("Pustok_Backend.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRememberMe")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Pustok_Backend.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2694),
                            Image = "brand-1.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2697)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2700),
                            Image = "brand-2.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2700)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2702),
                            Image = "brand-3.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2703)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2704),
                            Image = "brand-4.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2705)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2706),
                            Image = "brand-5.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2707)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2709),
                            Image = "brand-6.webp",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2709)
                        });
                });

            modelBuilder.Entity("Pustok_Backend.Models.Direction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "right"
                        },
                        new
                        {
                            Id = 2,
                            Name = "left"
                        });
                });

            modelBuilder.Entity("Pustok_Backend.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2365),
                            Description = "Orders over $500",
                            IconName = "fas fa-shipping-fast",
                            SoftDeleted = false,
                            Title = "Free Shipping Item",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2366)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2369),
                            Description = "100% money back",
                            IconName = "fas fa-redo-alt",
                            SoftDeleted = false,
                            Title = "Money Back Guarantee",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2370)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2371),
                            Description = "Lorem ipsum dolor amet",
                            IconName = "fas fa-piggy-bank",
                            SoftDeleted = false,
                            Title = "Cash On Delivery",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2372)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2374),
                            Description = "Call us : + 0123.4567.89",
                            IconName = "fas fa-life-ring",
                            SoftDeleted = false,
                            Title = "Help & Support",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2375)
                        });
                });

            modelBuilder.Entity("Pustok_Backend.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2739),
                            Key = "HeaderLogo",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2740),
                            Value = "logo.webp"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2742),
                            Key = "FooterLogo",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2743),
                            Value = "logo--footer.webp"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2745),
                            Key = "Address",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2745),
                            Value = "Example Street 98, HH2 BacHa, New York, USA"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2747),
                            Key = "Phone",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2748),
                            Value = "+18088 234 5678"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2749),
                            Key = "Email",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2750),
                            Value = "support@hastech.com"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2751),
                            Key = "PaymentMethod",
                            SoftDeleted = false,
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2752),
                            Value = "payment.webp"
                        });
                });

            modelBuilder.Entity("Pustok_Backend.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectionId")
                        .HasColumnType("int");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2090),
                            Description = " Cover Up Front Of Books and Leave Summary",
                            DirectionId = 1,
                            Header = "J.D. Kurtness",
                            Image = "home-slider-1-ai.webp",
                            SoftDeleted = false,
                            Title = "De Vengeance",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2102)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2110),
                            Description = "Cover Up Front Of Books and Leave Summary",
                            DirectionId = 2,
                            Header = "H.G. Wells",
                            Image = "home-slider-2-ai.webp",
                            SoftDeleted = false,
                            Title = "De Vengeance",
                            UpdatedDate = new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2111)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Pustok_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pustok_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pustok_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pustok_Backend.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pustok_Backend.Models.Slider", b =>
                {
                    b.HasOne("Pustok_Backend.Models.Direction", "Direction")
                        .WithMany("Sliders")
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");
                });

            modelBuilder.Entity("Pustok_Backend.Models.Direction", b =>
                {
                    b.Navigation("Sliders");
                });
#pragma warning restore 612, 618
        }
    }
}
