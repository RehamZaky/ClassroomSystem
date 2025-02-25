﻿// <auto-generated />
using System;
using Classroom.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Classroom.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Classroom.API.Domain.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 2, 25, 12, 4, 1, 288, DateTimeKind.Utc).AddTicks(5931),
                            Name = "cat1",
                            UpdatedAt = new DateTime(2025, 2, 25, 12, 4, 1, 288, DateTimeKind.Utc).AddTicks(5930)
                        });
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("classrooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 1,
                            CreatedAt = new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6036),
                            Description = "Object-oriented programming - OOP",
                            IsActive = true,
                            Price = 99.989999999999995,
                            Title = " #C",
                            UpdatedAt = new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6084)
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 1,
                            CreatedAt = new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6087),
                            Description = "SQL is a standard programming language used to manage and manipulate relational databases.",
                            IsActive = true,
                            Price = 120.5,
                            Title = "SQL",
                            UpdatedAt = new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6088)
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 1,
                            CreatedAt = new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6090),
                            Description = "ASP.NET Core is an open-source framework by Microsoft for building web applications",
                            IsActive = true,
                            Price = 150.0,
                            Title = "ASP.NET Core",
                            UpdatedAt = new DateTime(2025, 2, 25, 14, 4, 1, 288, DateTimeKind.Local).AddTicks(6092)
                        });
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Admin", b =>
                {
                    b.HasOne("Classroom.API.Domain.Entities.User", "User")
                        .WithOne("admin")
                        .HasForeignKey("Classroom.API.Domain.Entities.Admin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Category", b =>
                {
                    b.HasOne("Classroom.API.Domain.Entities.Category", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Classroom", b =>
                {
                    b.HasOne("Classroom.API.Domain.Entities.Category", "Category")
                        .WithMany("Classrooms")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Parent", b =>
                {
                    b.HasOne("Classroom.API.Domain.Entities.User", "User")
                        .WithOne("parent")
                        .HasForeignKey("Classroom.API.Domain.Entities.Parent", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Student", b =>
                {
                    b.HasOne("Classroom.API.Domain.Entities.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Classroom.API.Domain.Entities.User", "User")
                        .WithOne("Students")
                        .HasForeignKey("Classroom.API.Domain.Entities.Student", "userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Teacher", b =>
                {
                    b.HasOne("Classroom.API.Domain.Entities.User", "User")
                        .WithOne("teacher")
                        .HasForeignKey("Classroom.API.Domain.Entities.Teacher", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Category", b =>
                {
                    b.Navigation("Classrooms");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.Parent", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Classroom.API.Domain.Entities.User", b =>
                {
                    b.Navigation("Students")
                        .IsRequired();

                    b.Navigation("admin")
                        .IsRequired();

                    b.Navigation("parent")
                        .IsRequired();

                    b.Navigation("teacher")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
