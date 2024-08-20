﻿// <auto-generated />
using System;
using InsuranceWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceWebApplication.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("LastCreated")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<DateTime?>("LastDeleted")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<DateTime?>("LastModified")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("DECIMAL(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("InsuranceWebApplication.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarId")
                        .IsRequired()
                        .HasColumnType("INT");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("LastCreated")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<DateTime?>("LastDeleted")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<DateTime?>("LastModified")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<decimal?>("Premium")
                        .IsRequired()
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<int>("Status")
                        .HasColumnType("INT");

                    b.Property<string>("TypeOfInsurance")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("InsuranceWebApplication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthdate")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(254)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("LastCreated")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<DateTime?>("LastDeleted")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<DateTime?>("LastModified")
                        .IsRequired()
                        .HasColumnType("DATETIME2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(256)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InsuranceWebApplication.Models.VisitCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.ToTable("VisitCount");
                });

            modelBuilder.Entity("InsuranceWebApplication.Models.Insurance", b =>
                {
                    b.HasOne("InsuranceWebApplication.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsuranceWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
