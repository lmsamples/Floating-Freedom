﻿// <auto-generated />
using System;
using FloatingFreedom.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FloatingFreedom.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200131164727_addedUserName")]
    partial class addedUserName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FloatingFreedom.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            Address = "123 Infinity Way",
                            ConcurrencyStamp = "d720a020-3533-4714-90d1-0dc28d394d49",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Amin the Admin",
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHj/bJXDL5D78Z04LMz1HoAP+HHhyA2TSSmIppU9/SgwJTGwTZ5wc6BzpCE7O4XBmA==",
                            PhoneNumber = "304-123-1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "37451998-dfbf-4fef-854d-a0ee510f6869",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("FloatingFreedom.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KayakId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KayakId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "email@email.com",
                            KayakId = 1,
                            Name = "John Doe",
                            PhoneNumber = "304-123-1234",
                            RentalDate = new DateTime(2020, 1, 27, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 28, 5, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 2,
                            Email = "email@email.com",
                            KayakId = 18,
                            Name = "Anne Example",
                            PhoneNumber = "304-321-1111",
                            RentalDate = new DateTime(2020, 1, 27, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 28, 5, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("FloatingFreedom.Models.Kayak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KayakTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KayakTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Kayaks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KayakTypeId = 1,
                            Name = "Sun Dolphin Destin #01",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 2,
                            KayakTypeId = 1,
                            Name = "Sun Dolphin Destin #02",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 3,
                            KayakTypeId = 1,
                            Name = "Sun Dolphin Destin #03",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 4,
                            KayakTypeId = 1,
                            Name = "Sun Dolphin Destin #04",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 5,
                            KayakTypeId = 1,
                            Name = "Sun Dolphin Destin #05",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 6,
                            KayakTypeId = 2,
                            Name = "Sun Dolphin Phoenix #01",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 7,
                            KayakTypeId = 2,
                            Name = "Sun Dolphin Phoenix #02",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 8,
                            KayakTypeId = 2,
                            Name = "Sun Dolphin Phoenix #03",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 9,
                            KayakTypeId = 2,
                            Name = "Sun Dolphin Phoenix #04",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 10,
                            KayakTypeId = 2,
                            Name = "Sun Dolphin Phoenix #05",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 11,
                            KayakTypeId = 3,
                            Name = "Sun Dolphin Aruba #01",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 12,
                            KayakTypeId = 3,
                            Name = "Sun Dolphin Aruba #02",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 13,
                            KayakTypeId = 3,
                            Name = "Sun Dolphin Aruba #03",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 14,
                            KayakTypeId = 3,
                            Name = "Sun Dolphin Aruba #04",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 15,
                            KayakTypeId = 3,
                            Name = "Sun Dolphin Aruba #05",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 16,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #01",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 17,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #02",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 18,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #03",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 19,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #04",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 20,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #05",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 21,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #06",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 22,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #07",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 23,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #08",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 24,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #09",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 25,
                            KayakTypeId = 4,
                            Name = "Intex Explorer K2 #10",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 26,
                            KayakTypeId = 5,
                            Name = "BKC PK12 #01",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 27,
                            KayakTypeId = 5,
                            Name = "BKC PK12 #02",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            Id = 28,
                            KayakTypeId = 5,
                            Name = "BKC PK12 #03",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("FloatingFreedom.Models.KayakType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KayakTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sit-On-Top"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Recreational"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Touring"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Inflatable"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pedaling"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FloatingFreedom.Models.Customer", b =>
                {
                    b.HasOne("FloatingFreedom.Models.Kayak", "Kayak")
                        .WithMany("customers")
                        .HasForeignKey("KayakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FloatingFreedom.Models.ApplicationUser", "User")
                        .WithMany("Customers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FloatingFreedom.Models.Kayak", b =>
                {
                    b.HasOne("FloatingFreedom.Models.KayakType", "KayakType")
                        .WithMany()
                        .HasForeignKey("KayakTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FloatingFreedom.Models.ApplicationUser", "User")
                        .WithMany("Kayaks")
                        .HasForeignKey("UserId");
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
                    b.HasOne("FloatingFreedom.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FloatingFreedom.Models.ApplicationUser", null)
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

                    b.HasOne("FloatingFreedom.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FloatingFreedom.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
