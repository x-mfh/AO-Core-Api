﻿// <auto-generated />
using System;
using AoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AoApi.Data.Migrations
{
    [DbContext(typeof(AOContext))]
    [Migration("20190211084434_RemovedUserFromEmployeeModel")]
    partial class RemovedUserFromEmployeeModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AoApi.Data.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Birthday");

                    b.Property<string>("City")
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .HasMaxLength(20);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid>("JobId");

                    b.Property<string>("LastName")
                        .HasMaxLength(30);

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Street")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("JobId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d90a452-9547-4d04-98ed-7d617e64ae1e"),
                            Birthday = new DateTimeOffset(new DateTime(1980, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            City = "Copenhagen",
                            Country = "Denmark",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "MikkelHammer@gmail.com",
                            FirstName = "Mikkel",
                            IsDeleted = false,
                            JobId = new Guid("8068cbf6-c595-4733-9c24-8104e8454b4c"),
                            LastName = "Hammer",
                            PhoneNumber = "29482948",
                            Street = "Telegrafvej 9"
                        },
                        new
                        {
                            Id = new Guid("45c0c223-de18-4e6e-99ea-aed94e7469f1"),
                            Birthday = new DateTimeOffset(new DateTime(1980, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            City = "Copenhagen",
                            Country = "Denmark",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "BalenDezai@gmail.com",
                            FirstName = "Balen",
                            IsDeleted = false,
                            JobId = new Guid("8068cbf6-c595-4733-9c24-8104e8454b4c"),
                            LastName = "Dezai",
                            PhoneNumber = "29482949",
                            Street = "Telegrafvej 9"
                        },
                        new
                        {
                            Id = new Guid("de9b842d-531a-4f17-ad69-0d3e11cb911d"),
                            Birthday = new DateTimeOffset(new DateTime(1997, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            City = "Copenhagen",
                            Country = "Denmark",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "JasonSabeniano@gmail.com",
                            FirstName = "Jason",
                            IsDeleted = false,
                            JobId = new Guid("8068cbf6-c595-4733-9c24-8104e8454b4c"),
                            LastName = "Sabeniano",
                            PhoneNumber = "29482950",
                            Street = "Telegrafvej 9"
                        },
                        new
                        {
                            Id = new Guid("195c5a46-96f9-446b-b4f7-864ab2dc49de"),
                            Birthday = new DateTimeOffset(new DateTime(1883, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            City = "Prague",
                            Country = "Czech republic",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "FranzKafka@gmail.com",
                            FirstName = "Franz",
                            IsDeleted = false,
                            JobId = new Guid("72163c34-3d32-4a78-9701-1f708053978f"),
                            LastName = "Kafka",
                            PhoneNumber = "29482948",
                            Street = "Telegrafvej 9"
                        },
                        new
                        {
                            Id = new Guid("174fd8d4-f72b-4059-a7ea-05e687026b0d"),
                            Birthday = new DateTimeOffset(new DateTime(1821, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            City = "Moskva",
                            Country = "Russia",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "FjordorDostojevskij@gmail.com",
                            FirstName = "Fjodor",
                            IsDeleted = false,
                            JobId = new Guid("0532f0df-c92d-4a10-9d1a-8a5935c541a2"),
                            LastName = "Dostojevskij",
                            PhoneNumber = "29482948",
                            Street = "Telegrafvej 9"
                        },
                        new
                        {
                            Id = new Guid("163c03b3-a057-426d-afa3-1a2631a693e2"),
                            Birthday = new DateTimeOffset(new DateTime(1899, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            City = "Springfield",
                            Country = "USA",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "ErnestHemingway@gmail.com",
                            FirstName = "Ernest",
                            IsDeleted = false,
                            JobId = new Guid("76c2fab8-7161-49b7-88c6-f3aaf484ea64"),
                            LastName = "Hemingway",
                            PhoneNumber = "29482948",
                            Street = "Telegrafvej 9"
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8068cbf6-c595-4733-9c24-8104e8454b4c"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Chief Executive Officer",
                            JobTitle = "CEO"
                        },
                        new
                        {
                            Id = new Guid("6e0a64bc-7a50-4a6c-9125-8ccf6e54bf70"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Chief Information Officer",
                            JobTitle = "CIO"
                        },
                        new
                        {
                            Id = new Guid("72163c34-3d32-4a78-9701-1f708053978f"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "IT Administrator",
                            JobTitle = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("e143ebff-a0bd-4107-889f-9bff26eda916"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            JobTitle = "Sales Manager"
                        },
                        new
                        {
                            Id = new Guid("01c66e3e-8c25-4f5c-a2c5-512c79d09aa6"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            JobTitle = "Accountant"
                        },
                        new
                        {
                            Id = new Guid("976a7a24-1c25-4a7f-97c6-1a019c5c148d"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            JobTitle = "IT-Support"
                        },
                        new
                        {
                            Id = new Guid("0532f0df-c92d-4a10-9d1a-8a5935c541a2"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            JobTitle = "Sales Assitant"
                        },
                        new
                        {
                            Id = new Guid("76c2fab8-7161-49b7-88c6-f3aaf484ea64"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "",
                            JobTitle = "Janitor"
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b48d780f-44ad-408f-b5f6-81bdfe15e617"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            RoleTitle = "Master Administrator"
                        },
                        new
                        {
                            Id = new Guid("a3d1a284-6ce6-494a-a616-822239df2799"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            RoleTitle = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("a105fa9d-8b3e-4a80-84e5-4a97c42ed931"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            RoleTitle = "Employee"
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<Guid>("EmployeeId");

                    b.Property<DateTimeOffset>("EndHour");

                    b.Property<bool>("IsHoliday");

                    b.Property<bool>("IsWeekend");

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.Property<DateTimeOffset>("StartHour");

                    b.Property<DateTimeOffset>("WorkDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = new Guid("092ca7c5-ae83-4a52-a38b-cfc7c8e40e9a"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("9d90a452-9547-4d04-98ed-7d617e64ae1e"),
                            EndHour = new DateTimeOffset(new DateTime(2018, 12, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            IsHoliday = false,
                            IsWeekend = false,
                            StartHour = new DateTimeOffset(new DateTime(2018, 12, 23, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            WorkDate = new DateTimeOffset(new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("5e0d5ad3-22b0-4bdc-808c-62b8f50d0796"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("45c0c223-de18-4e6e-99ea-aed94e7469f1"),
                            EndHour = new DateTimeOffset(new DateTime(2019, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            IsHoliday = true,
                            IsWeekend = true,
                            StartHour = new DateTimeOffset(new DateTime(2019, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            WorkDate = new DateTimeOffset(new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("cf3c5f8e-94ee-494a-b0f1-4a48d9d8291f"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("de9b842d-531a-4f17-ad69-0d3e11cb911d"),
                            EndHour = new DateTimeOffset(new DateTime(2019, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            IsHoliday = true,
                            IsWeekend = true,
                            StartHour = new DateTimeOffset(new DateTime(2019, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            WorkDate = new DateTimeOffset(new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Email");

                    b.Property<Guid>("EmployeeId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.Property<string>("Password")
                        .HasMaxLength(20);

                    b.Property<Guid>("RoleId");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a28ea13-7a24-4a4c-8394-37605ff69c82"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "SU@gmail.com",
                            EmployeeId = new Guid("de9b842d-531a-4f17-ad69-0d3e11cb911d"),
                            IsDeleted = false,
                            Password = "SU1234",
                            RoleId = new Guid("b48d780f-44ad-408f-b5f6-81bdfe15e617"),
                            Username = "Superuser"
                        },
                        new
                        {
                            Id = new Guid("a3d1a284-6ce6-494a-a616-822239df2799"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "AU@gmail.com",
                            EmployeeId = new Guid("195c5a46-96f9-446b-b4f7-864ab2dc49de"),
                            IsDeleted = false,
                            Password = "AU1234",
                            RoleId = new Guid("a3d1a284-6ce6-494a-a616-822239df2799"),
                            Username = "Administrativeuser"
                        },
                        new
                        {
                            Id = new Guid("a105fa9d-8b3e-4a80-84e5-4a97c42ed931"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "EU@gmail.com",
                            EmployeeId = new Guid("163c03b3-a057-426d-afa3-1a2631a693e2"),
                            IsDeleted = false,
                            Password = "EU1234",
                            RoleId = new Guid("a105fa9d-8b3e-4a80-84e5-4a97c42ed931"),
                            Username = "Employeeuser"
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<Guid>("EmployeeId");

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.Property<string>("PaymentMethod")
                        .IsRequired();

                    b.Property<int>("Salary");

                    b.Property<int>("Wage");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("303814ca-54f0-4fbb-955b-7ffd33b10b9d"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("9d90a452-9547-4d04-98ed-7d617e64ae1e"),
                            PaymentMethod = "Monthly",
                            Salary = 0,
                            Wage = 50000
                        },
                        new
                        {
                            Id = new Guid("ce442ad4-37a4-43f4-9a6d-5f7ab15df011"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("45c0c223-de18-4e6e-99ea-aed94e7469f1"),
                            PaymentMethod = "Monthly",
                            Salary = 0,
                            Wage = 50000
                        },
                        new
                        {
                            Id = new Guid("7f36e8e7-b5cd-43ef-a71d-8cfa2355d8ab"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("de9b842d-531a-4f17-ad69-0d3e11cb911d"),
                            PaymentMethod = "Monthly",
                            Salary = 0,
                            Wage = 50000
                        },
                        new
                        {
                            Id = new Guid("68accfc2-b922-4519-9bd2-20e235b6db2e"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("195c5a46-96f9-446b-b4f7-864ab2dc49de"),
                            PaymentMethod = "Monthly",
                            Salary = 600,
                            Wage = 0
                        },
                        new
                        {
                            Id = new Guid("f2d86ec1-0735-4f47-8087-0c5c311f3b74"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("174fd8d4-f72b-4059-a7ea-05e687026b0d"),
                            PaymentMethod = "Hourly",
                            Salary = 400,
                            Wage = 0
                        },
                        new
                        {
                            Id = new Guid("8ae640bb-1534-4e25-aa97-d85128d50aa8"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("163c03b3-a057-426d-afa3-1a2631a693e2"),
                            PaymentMethod = "Hourly",
                            Salary = 300,
                            Wage = 0
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.Workhours", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<Guid>("EmployeeId");

                    b.Property<DateTimeOffset?>("ModifiedOn");

                    b.Property<int>("TotalHoursThisPaycheck");

                    b.Property<int>("TotalOvertimeHoursThisPaycheck");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Workhours");

                    b.HasData(
                        new
                        {
                            Id = new Guid("044b879d-1486-4bc5-9907-2a7e14c84f7c"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("9d90a452-9547-4d04-98ed-7d617e64ae1e"),
                            TotalHoursThisPaycheck = 32,
                            TotalOvertimeHoursThisPaycheck = 0
                        },
                        new
                        {
                            Id = new Guid("1d0d61a3-9dff-4f0b-abc3-524b310d6fe4"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("45c0c223-de18-4e6e-99ea-aed94e7469f1"),
                            TotalHoursThisPaycheck = 32,
                            TotalOvertimeHoursThisPaycheck = 0
                        },
                        new
                        {
                            Id = new Guid("9af65a2d-a8bd-410c-a3a2-61b8b2427f5e"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("de9b842d-531a-4f17-ad69-0d3e11cb911d"),
                            TotalHoursThisPaycheck = 32,
                            TotalOvertimeHoursThisPaycheck = 0
                        },
                        new
                        {
                            Id = new Guid("ad0a45a1-59e0-47ac-9132-b3f4aea940f9"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("195c5a46-96f9-446b-b4f7-864ab2dc49de"),
                            TotalHoursThisPaycheck = 32,
                            TotalOvertimeHoursThisPaycheck = 5
                        },
                        new
                        {
                            Id = new Guid("40ac68bf-f764-4e0f-9197-dcf365c493af"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("174fd8d4-f72b-4059-a7ea-05e687026b0d"),
                            TotalHoursThisPaycheck = 32,
                            TotalOvertimeHoursThisPaycheck = 5
                        },
                        new
                        {
                            Id = new Guid("1a7824d4-e3d3-4be7-bf6e-3a2c52583628"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            EmployeeId = new Guid("163c03b3-a057-426d-afa3-1a2631a693e2"),
                            TotalHoursThisPaycheck = 32,
                            TotalOvertimeHoursThisPaycheck = 20
                        });
                });

            modelBuilder.Entity("AoApi.Data.Models.Employee", b =>
                {
                    b.HasOne("AoApi.Data.Models.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AoApi.Data.Models.Schedule", b =>
                {
                    b.HasOne("AoApi.Data.Models.Employee", "Employee")
                        .WithMany("Schedules")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AoApi.Data.Models.User", b =>
                {
                    b.HasOne("AoApi.Data.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AoApi.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AoApi.Data.Models.Wallet", b =>
                {
                    b.HasOne("AoApi.Data.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AoApi.Data.Models.Workhours", b =>
                {
                    b.HasOne("AoApi.Data.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
