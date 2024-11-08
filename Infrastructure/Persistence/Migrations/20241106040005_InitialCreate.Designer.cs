﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241106040005_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Branchies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Branchies");
                });

            modelBuilder.Entity("Domain.Entities.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Motor")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("FuelTypeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Colors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Domain.Entities.Commits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CommitMessage")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CustumerId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustumerId");

                    b.HasIndex("UserId");

                    b.ToTable("Commits");
                });

            modelBuilder.Entity("Domain.Entities.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Entities.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Domain.Entities.Filters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Filters");
                });

            modelBuilder.Entity("Domain.Entities.FuelTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("Domain.Entities.OilChangeFiltersMatrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FiltersId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OilChangesId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("FiltersId");

                    b.HasIndex("OilChangesId");

                    b.ToTable("OilChangeFiltersMatrix");
                });

            modelBuilder.Entity("Domain.Entities.OilChanges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("BranchiesId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CarsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("CustumerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KilometersTravelled")
                        .HasColumnType("int");

                    b.Property<decimal>("LitersUsed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OilTypeId")
                        .HasColumnType("int");

                    b.Property<int>("OilTypesId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("BranchiesId");

                    b.HasIndex("CarsId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("OilTypesId");

                    b.HasIndex("ProductsId");

                    b.HasIndex("ServicesId");

                    b.ToTable("OilChanges");
                });

            modelBuilder.Entity("Domain.Entities.OilTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("OilTypes");
                });

            modelBuilder.Entity("Domain.Entities.Phones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BranchiesId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("BranchiesId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Domain.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entities.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Domain.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UsersCarsMatrix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CustumerId")
                        .HasColumnType("int");

                    b.Property<int>("InsertedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("UpdatedDate")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustumerId");

                    b.ToTable("UsersCarsMatrix");
                });

            modelBuilder.Entity("Domain.Entities.Cars", b =>
                {
                    b.HasOne("Domain.Entities.Colors", "Colors")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.FuelTypes", "FuelType")
                        .WithMany("Cars")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colors");

                    b.Navigation("FuelType");
                });

            modelBuilder.Entity("Domain.Entities.Commits", b =>
                {
                    b.HasOne("Domain.Entities.Customers", "Customers")
                        .WithMany("Commits")
                        .HasForeignKey("CustumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.OilChangeFiltersMatrix", b =>
                {
                    b.HasOne("Domain.Entities.Filters", "Filter")
                        .WithMany("OilChangeFilters")
                        .HasForeignKey("FiltersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.OilChanges", "OilChanges")
                        .WithMany("OilChangeFilters")
                        .HasForeignKey("OilChangesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filter");

                    b.Navigation("OilChanges");
                });

            modelBuilder.Entity("Domain.Entities.OilChanges", b =>
                {
                    b.HasOne("Domain.Entities.Branchies", "Branchies")
                        .WithMany("OilChanges")
                        .HasForeignKey("BranchiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Cars", "Cars")
                        .WithMany("OilChanges")
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customers", "Customers")
                        .WithMany("OilChanges")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Employees", "Employees")
                        .WithMany("OilChanges")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.OilTypes", "OilTypes")
                        .WithMany("OilChanges")
                        .HasForeignKey("OilTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Products", "Products")
                        .WithMany("OilChanges")
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Services", "Services")
                        .WithMany("OilChanges")
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branchies");

                    b.Navigation("Cars");

                    b.Navigation("Customers");

                    b.Navigation("Employees");

                    b.Navigation("OilTypes");

                    b.Navigation("Products");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Domain.Entities.Phones", b =>
                {
                    b.HasOne("Domain.Entities.Branchies", null)
                        .WithMany("Phones")
                        .HasForeignKey("BranchiesId");
                });

            modelBuilder.Entity("Domain.Entities.UsersCarsMatrix", b =>
                {
                    b.HasOne("Domain.Entities.Cars", "Cars")
                        .WithMany("UsersCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customers", "Customers")
                        .WithMany("UsersCars")
                        .HasForeignKey("CustumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cars");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Domain.Entities.Branchies", b =>
                {
                    b.Navigation("OilChanges");

                    b.Navigation("Phones");
                });

            modelBuilder.Entity("Domain.Entities.Cars", b =>
                {
                    b.Navigation("OilChanges");

                    b.Navigation("UsersCars");
                });

            modelBuilder.Entity("Domain.Entities.Colors", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Customers", b =>
                {
                    b.Navigation("Commits");

                    b.Navigation("OilChanges");

                    b.Navigation("UsersCars");
                });

            modelBuilder.Entity("Domain.Entities.Employees", b =>
                {
                    b.Navigation("OilChanges");
                });

            modelBuilder.Entity("Domain.Entities.Filters", b =>
                {
                    b.Navigation("OilChangeFilters");
                });

            modelBuilder.Entity("Domain.Entities.FuelTypes", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.OilChanges", b =>
                {
                    b.Navigation("OilChangeFilters");
                });

            modelBuilder.Entity("Domain.Entities.OilTypes", b =>
                {
                    b.Navigation("OilChanges");
                });

            modelBuilder.Entity("Domain.Entities.Products", b =>
                {
                    b.Navigation("OilChanges");
                });

            modelBuilder.Entity("Domain.Entities.Services", b =>
                {
                    b.Navigation("OilChanges");
                });
#pragma warning restore 612, 618
        }
    }
}
