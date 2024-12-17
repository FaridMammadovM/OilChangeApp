using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineCapacity = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SAEViscosities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAEViscosities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WinterViscosities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    IsBrakeFluidChanged = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterViscosities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Branchies_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOtp = table.Column<bool>(type: "bit", nullable: false),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommitMessage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CustumerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commits_Customers_CustumerId",
                        column: x => x.CustumerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersCarsMatrix",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CarNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MotorId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ColorsId = table.Column<int>(type: "int", nullable: true),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersCarsMatrix", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersCarsMatrix_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersCarsMatrix_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomersCarsMatrix_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersCarsMatrix_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersCarsMatrix_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OilChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersCarsMatrixId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SAEViscosityId = table.Column<int>(type: "int", nullable: false),
                    WinterViscosityId = table.Column<int>(type: "int", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KilometersTravelled = table.Column<int>(type: "int", nullable: false),
                    OilVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OilOwn = table.Column<bool>(type: "bit", nullable: false),
                    OilCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OilChanges_Branchies_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_CustomersCarsMatrix_CustomersCarsMatrixId",
                        column: x => x.CustomersCarsMatrixId,
                        principalTable: "CustomersCarsMatrix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_SAEViscosities_SAEViscosityId",
                        column: x => x.SAEViscosityId,
                        principalTable: "SAEViscosities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_WinterViscosities_WinterViscosityId",
                        column: x => x.WinterViscosityId,
                        principalTable: "WinterViscosities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OilChangeFiltersMatrix",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OilChangesId = table.Column<int>(type: "int", nullable: false),
                    FiltersId = table.Column<int>(type: "int", nullable: false),
                    FilterOwn = table.Column<bool>(type: "bit", nullable: false),
                    FilterCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilChangeFiltersMatrix", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OilChangeFiltersMatrix_Filters_FiltersId",
                        column: x => x.FiltersId,
                        principalTable: "Filters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChangeFiltersMatrix_OilChanges_OilChangesId",
                        column: x => x.OilChangesId,
                        principalTable: "OilChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branchies",
                columns: new[] { "Id", "Address", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "General Şixlinski küçəsi,264 saylı məktəbin yanı", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6157), "Əhmədli filialı", null, null },
                    { 2, "Şeyx Məhəmməd Xiyabani 51", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6160), "Yasamal filialı", null, null },
                    { 3, "Binəqədi şosesi 1. Binəqədi 4yol", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6161), "Binəqədi filialı", null, null },
                    { 4, "Yavər Əliyev 68A", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6163), "Bakıxanov filialı", null, null },
                    { 5, "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6164), "Xətai filialı", null, null },
                    { 6, "Sumqayıt-çerkasski 78", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6165), "Sumqayıt filialı", null, null },
                    { 7, "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6167), "Gəncə filialı", null, null },
                    { 8, "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6200), "Xaçmaz filialı", null, null },
                    { 9, "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(6201), "Quba filialı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8064), "X5", null, null },
                    { 2, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8066), "M3", null, null },
                    { 3, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8068), "M4", null, null },
                    { 4, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8069), "M2", null, null },
                    { 5, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8070), "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8072), "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8073), "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8074), "X3", null, null },
                    { 9, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8075), "X4", null, null },
                    { 10, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8077), "X6", null, null },
                    { 11, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8078), "X7", null, null },
                    { 12, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8079), "i3", null, null },
                    { 13, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8081), "i4", null, null },
                    { 14, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8082), "iX", null, null },
                    { 15, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8083), "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8084), "530e", null, null },
                    { 17, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8086), "750i", null, null },
                    { 18, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8087), "M5", null, null },
                    { 19, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8088), "M8", null, null },
                    { 20, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8089), "i7", null, null },
                    { 21, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8091), "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8092), "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8095), "M6", null, null },
                    { 24, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8096), "320i", null, null },
                    { 25, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8097), "420i", null, null },
                    { 26, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8098), "520d", null, null },
                    { 27, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8100), "730d", null, null },
                    { 28, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8101), "740i", null, null },
                    { 29, "BMW", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8102), "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8103), "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8104), "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8106), "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8107), "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8108), "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8110), "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8111), "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8112), "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8113), "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8115), "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8116), "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8117), "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8118), "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8119), "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8121), "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8123), "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8124), "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8125), "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8126), "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8127), "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8129), "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8130), "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8132), "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8133), "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8134), "A4", null, null },
                    { 55, "Audi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8136), "A6", null, null },
                    { 56, "Audi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8137), "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8138), "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8139), "A8", null, null },
                    { 59, "Audi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8141), "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8142), "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8164), "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8165), "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8167), "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8168), "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8169), "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8170), "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8173), "K5", null, null },
                    { 68, "Kia", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8174), "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8175), "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8176), "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8177), "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8180), "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8181), "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8182), "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8184), "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8185), "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8187), "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8188), "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8189), "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8191), "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8192), "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8193), "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8194), "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8196), "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8197), "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8198), "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8199), "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8200), "911", null, null },
                    { 89, "Porsche", null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(8202), "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9867), "Ağ", null, null },
                    { 2, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9872), "Qara", null, null },
                    { 3, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9873), "Qırmızı", null, null },
                    { 4, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9873), "Yaşıl", null, null },
                    { 5, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9874), "Mavi", null, null },
                    { 6, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9875), "Sarı", null, null },
                    { 7, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9876), "Narıncı", null, null },
                    { 8, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9876), "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9877), "Çəhrayı", null, null },
                    { 10, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9878), "Boz", null, null },
                    { 11, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9879), "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9879), "Göy", null, null },
                    { 13, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9880), "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9881), "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9881), "Tünd mavi", null, null },
                    { 16, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9882), "Açıq mavi", null, null },
                    { 17, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9883), "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9883), "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9884), "Bürünc", null, null },
                    { 20, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9885), "Gümüşü", null, null },
                    { 21, null, new DateTime(2024, 12, 17, 22, 54, 48, 610, DateTimeKind.Local).AddTicks(9885), "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(8285), "Master Employee", "Master", null, null });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(9861), "Yağ", null, null },
                    { 2, null, new DateTime(2024, 12, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(9863), "Hava", null, null },
                    { 3, null, new DateTime(2024, 12, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(9864), "Yanacaq", null, null },
                    { 4, null, new DateTime(2024, 12, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(9865), "Salon", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(1412), "Benzin", null, null },
                    { 2, null, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(1414), "Qaz", null, null },
                    { 3, null, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(1416), "Dizel", null, null },
                    { 4, null, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(1417), "Elektro", null, null },
                    { 5, null, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(1418), "Hybrid", null, null },
                    { 6, null, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(1419), "Plug-in Hybrid", null, null }
                });

            migrationBuilder.InsertData(
                table: "Motors",
                columns: new[] { "Id", "EngineCapacity", "InsertedBy", "InsertedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2935), null, null },
                    { 2, 200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2938), null, null },
                    { 3, 300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2939), null, null },
                    { 4, 400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2940), null, null },
                    { 5, 500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2941), null, null },
                    { 6, 600m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2944), null, null },
                    { 7, 700m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2945), null, null },
                    { 8, 800m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2946), null, null },
                    { 9, 900m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2947), null, null },
                    { 10, 1000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2949), null, null },
                    { 11, 1100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2949), null, null },
                    { 12, 1200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2950), null, null },
                    { 13, 1300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2951), null, null },
                    { 14, 1400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2952), null, null },
                    { 15, 1500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2953), null, null },
                    { 16, 1600m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2954), null, null },
                    { 17, 1700m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2954), null, null },
                    { 18, 1800m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2956), null, null },
                    { 19, 1900m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2957), null, null },
                    { 20, 2000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2957), null, null },
                    { 21, 2100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2958), null, null },
                    { 22, 2200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2959), null, null },
                    { 23, 2300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2960), null, null },
                    { 24, 2400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2961), null, null },
                    { 25, 2500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2962), null, null },
                    { 26, 2600m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2962), null, null },
                    { 27, 2700m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2963), null, null },
                    { 28, 2800m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2964), null, null },
                    { 29, 2900m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2965), null, null },
                    { 30, 3000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2966), null, null },
                    { 31, 3100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2967), null, null },
                    { 32, 3200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2968), null, null },
                    { 33, 3300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2969), null, null },
                    { 34, 3400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2970), null, null },
                    { 35, 3500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2971), null, null },
                    { 36, 3600m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2972), null, null },
                    { 37, 3700m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2973), null, null },
                    { 38, 3800m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2974), null, null },
                    { 39, 3900m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2975), null, null },
                    { 40, 4000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2998), null, null },
                    { 41, 4100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(2999), null, null },
                    { 42, 4200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3000), null, null },
                    { 43, 4300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3001), null, null },
                    { 44, 4400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3002), null, null },
                    { 45, 4500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3002), null, null },
                    { 46, 4600m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3003), null, null },
                    { 47, 4700m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3004), null, null },
                    { 48, 4800m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3005), null, null },
                    { 49, 4900m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3006), null, null },
                    { 50, 5000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3007), null, null },
                    { 51, 5100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3007), null, null },
                    { 52, 5200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3008), null, null },
                    { 53, 5300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3009), null, null },
                    { 54, 5400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3010), null, null },
                    { 55, 5500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3011), null, null },
                    { 56, 5600m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3012), null, null },
                    { 57, 5700m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3012), null, null },
                    { 58, 5800m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3013), null, null },
                    { 59, 5900m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3014), null, null },
                    { 60, 6000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3015), null, null },
                    { 61, 6100m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3016), null, null },
                    { 62, 6200m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3016), null, null },
                    { 63, 6300m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3017), null, null },
                    { 64, 6400m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3018), null, null },
                    { 65, 6500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3019), null, null },
                    { 66, 6500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3021), null, null },
                    { 67, 7000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3023), null, null },
                    { 68, 7500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3023), null, null },
                    { 69, 8000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3024), null, null },
                    { 70, 8500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3025), null, null },
                    { 71, 9000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3026), null, null },
                    { 72, 9500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3027), null, null },
                    { 73, 10000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3028), null, null },
                    { 74, 10500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3029), null, null },
                    { 75, 11000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3029), null, null },
                    { 76, 11500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3030), null, null },
                    { 77, 12000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3031), null, null },
                    { 78, 12500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3032), null, null },
                    { 79, 13000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3033), null, null },
                    { 80, 13500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3034), null, null },
                    { 81, 14000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3034), null, null },
                    { 82, 14500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3035), null, null },
                    { 83, 15000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3036), null, null },
                    { 84, 15500m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3037), null, null },
                    { 85, 16000m, 3, new DateTime(2024, 12, 17, 22, 54, 48, 612, DateTimeKind.Local).AddTicks(3038), null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(9428), false, "Elf", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(633), false, "Costumer", null, null },
                    { 2, null, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(635), false, "Branch", null, null }
                });

            migrationBuilder.InsertData(
                table: "SAEViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(1848), false, null, null },
                    { 2, 5, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(1850), false, null, null },
                    { 3, 10, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(1852), false, null, null },
                    { 4, 20, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(1853), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3344), "Sürətlər qutusu yağ dəyişmə", null, null },
                    { 2, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3347), "Mühərrik yağ dəyişmə", null, null },
                    { 3, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3348), "Antifiriz dəyişmə", null, null },
                    { 4, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3350), "Əyləc mayesi dəyişmə", null, null },
                    { 5, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3351), "Arxa körpü", null, null },
                    { 6, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3352), "Ön körpü", null, null },
                    { 7, 1, new DateTime(2024, 12, 17, 22, 54, 48, 616, DateTimeKind.Local).AddTicks(3353), "Diferensial (Razdatka)", null, null }
                });

            migrationBuilder.InsertData(
                table: "WinterViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsBrakeFluidChanged", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 8m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7716), false, false, null, null },
                    { 2, 12m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7719), false, false, null, null },
                    { 3, 16m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7720), false, false, null, null },
                    { 4, 20m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7722), false, false, null, null },
                    { 5, 30m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7724), false, false, null, null },
                    { 6, 40m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7725), false, false, null, null },
                    { 7, 50m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7727), false, false, null, null },
                    { 8, 60m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7728), false, false, null, null },
                    { 9, 3m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7730), true, false, null, null },
                    { 10, 4m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7731), true, false, null, null },
                    { 11, 5.1m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7734), true, false, null, null },
                    { 12, 6m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7735), true, false, null, null },
                    { 13, 5m, 1, new DateTime(2024, 12, 17, 22, 54, 48, 617, DateTimeKind.Local).AddTicks(7737), true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsOtp", "Name", "Password", "Phone", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(6523), false, "Master Admin", "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K", "+994000", "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=", new DateTime(2025, 2, 17, 22, 54, 48, 611, DateTimeKind.Local).AddTicks(6505), 2, "Master", null, null });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "BranchId", "InsertedBy", "InsertedDate", "IsDeleted", "Phone", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8048), false, "+994703305788", null, null },
                    { 2, 2, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8050), false, "+994702343134", null, null },
                    { 3, 2, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8052), false, "+994706843434", null, null },
                    { 4, 4, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8053), false, "+994777332322", null, null },
                    { 5, 4, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8055), false, "+994706743434", null, null },
                    { 6, 3, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8056), false, "+994707552322", null, null },
                    { 7, 3, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8058), false, "+994702153434", null, null },
                    { 8, 3, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8059), false, "+994702344334", null, null },
                    { 9, 3, 1, new DateTime(2024, 12, 17, 22, 54, 48, 615, DateTimeKind.Local).AddTicks(8060), false, "+994702344334", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commits_CustumerId",
                table: "Commits",
                column: "CustumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoleId",
                table: "Customers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCarsMatrix_CarId",
                table: "CustomersCarsMatrix",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCarsMatrix_ColorsId",
                table: "CustomersCarsMatrix",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCarsMatrix_CustomerId",
                table: "CustomersCarsMatrix",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCarsMatrix_FuelTypeId",
                table: "CustomersCarsMatrix",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCarsMatrix_MotorId",
                table: "CustomersCarsMatrix",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChangeFiltersMatrix_FiltersId",
                table: "OilChangeFiltersMatrix",
                column: "FiltersId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChangeFiltersMatrix_OilChangesId",
                table: "OilChangeFiltersMatrix",
                column: "OilChangesId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_BranchId",
                table: "OilChanges",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_CustomersCarsMatrixId",
                table: "OilChanges",
                column: "CustomersCarsMatrixId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_EmployeeId",
                table: "OilChanges",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_ProductId",
                table: "OilChanges",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_SAEViscosityId",
                table: "OilChanges",
                column: "SAEViscosityId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_ServiceId",
                table: "OilChanges",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_WinterViscosityId",
                table: "OilChanges",
                column: "WinterViscosityId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_BranchId",
                table: "Phones",
                column: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commits");

            migrationBuilder.DropTable(
                name: "OilChangeFiltersMatrix");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "OilChanges");

            migrationBuilder.DropTable(
                name: "Branchies");

            migrationBuilder.DropTable(
                name: "CustomersCarsMatrix");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SAEViscosities");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "WinterViscosities");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Motors");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
