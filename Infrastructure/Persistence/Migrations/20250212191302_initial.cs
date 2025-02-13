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
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
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
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
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
                    ServiceType = table.Column<int>(type: "int", nullable: false),
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
                    OtpCode = table.Column<int>(type: "int", nullable: true),
                    NotificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtpExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    IsRequest = table.Column<bool>(type: "bit", nullable: false),
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
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    SAEViscosityId = table.Column<int>(type: "int", nullable: true),
                    WinterViscosityId = table.Column<int>(type: "int", nullable: true),
                    Indicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KilometersTravelled = table.Column<int>(type: "int", nullable: true),
                    Volume = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OilOwn = table.Column<bool>(type: "bit", nullable: false),
                    OilCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OilChanges_SAEViscosities_SAEViscosityId",
                        column: x => x.SAEViscosityId,
                        principalTable: "SAEViscosities",
                        principalColumn: "Id");
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
                        principalColumn: "Id");
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
                    FilterCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "Address", "InsertedBy", "InsertedDate", "Latitude", "Longitude", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "General Şixlinski küçəsi,264 saylı məktəbin yanı", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1822), 40.377934038599093, 49.965220500000001, "Əhmədli filialı", null, null },
                    { 2, "Şeyx Məhəmməd Xiyabani 51", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1825), 40.397900118850174, 49.791563413492469, "Yasamal filialı", null, null },
                    { 3, "Binəqədi şosesi 1. Binəqədi 4yol", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1827), 40.462704502468668, 49.841030328835842, "Binəqədi filialı", null, null },
                    { 4, "Yavər Əliyev 68A", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1828), 40.434890561885261, 49.956894584656602, "Bakıxanov filialı", null, null },
                    { 5, "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1830), 40.377696942229683, 49.872018853149022, "Xətai filialı", null, null },
                    { 6, "Sumqayıt-çerkasski 78", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1831), 40.573295524244287, 49.668450085584176, "Sumqayıt filialı", null, null },
                    { 7, "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1833), 40.666969417582393, 46.352373390200576, "Gəncə filialı", null, null },
                    { 8, "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1834), 41.475965700000003, 48.77674875767169, "Xaçmaz filialı", null, null },
                    { 9, "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(1836), 41.363251986092024, 48.536400677710169, "Quba filialı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3582), "X5", null, null },
                    { 2, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3584), "M3", null, null },
                    { 3, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3585), "M4", null, null },
                    { 4, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3588), "M2", null, null },
                    { 5, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3590), "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3592), "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3593), "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3595), "X3", null, null },
                    { 9, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3597), "X4", null, null },
                    { 10, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3598), "X6", null, null },
                    { 11, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3599), "X7", null, null },
                    { 12, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3601), "i3", null, null },
                    { 13, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3602), "i4", null, null },
                    { 14, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3603), "iX", null, null },
                    { 15, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3604), "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3606), "530e", null, null },
                    { 17, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3607), "750i", null, null },
                    { 18, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3608), "M5", null, null },
                    { 19, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3609), "M8", null, null },
                    { 20, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3611), "i7", null, null },
                    { 21, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3612), "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3613), "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3614), "M6", null, null },
                    { 24, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3615), "320i", null, null },
                    { 25, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3618), "420i", null, null },
                    { 26, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3619), "520d", null, null },
                    { 27, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3620), "730d", null, null },
                    { 28, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3621), "740i", null, null },
                    { 29, "BMW", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3623), "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3624), "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3626), "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3627), "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3629), "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3630), "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3631), "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3632), "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3634), "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3635), "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3637), "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3638), "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3639), "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3640), "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3642), "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3644), "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3645), "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3646), "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3648), "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3649), "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3650), "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3651), "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3652), "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3654), "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3655), "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3656), "A4", null, null },
                    { 55, "Audi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3658), "A6", null, null },
                    { 56, "Audi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3659), "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3660), "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3661), "A8", null, null },
                    { 59, "Audi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3662), "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3664), "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3665), "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3667), "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3668), "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3669), "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3670), "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3672), "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3673), "K5", null, null },
                    { 68, "Kia", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3675), "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3676), "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3677), "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3678), "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3680), "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3681), "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3682), "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3683), "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3685), "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3686), "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3687), "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3688), "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3689), "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3690), "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3692), "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3693), "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3694), "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3695), "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3696), "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3698), "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3699), "911", null, null },
                    { 89, "Porsche", null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(3700), "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5212), "Ağ", null, null },
                    { 2, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5217), "Qara", null, null },
                    { 3, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5217), "Qırmızı", null, null },
                    { 4, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5218), "Yaşıl", null, null },
                    { 5, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5219), "Mavi", null, null },
                    { 6, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5220), "Sarı", null, null },
                    { 7, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5220), "Narıncı", null, null },
                    { 8, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5221), "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5221), "Çəhrayı", null, null },
                    { 10, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5222), "Boz", null, null },
                    { 11, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5223), "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5223), "Göy", null, null },
                    { 13, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5224), "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5225), "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5225), "Tünd mavi", null, null },
                    { 16, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5226), "Açıq mavi", null, null },
                    { 17, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5227), "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5227), "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5228), "Bürünc", null, null },
                    { 20, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5229), "Gümüşü", null, null },
                    { 21, null, new DateTime(2025, 2, 12, 23, 13, 1, 803, DateTimeKind.Local).AddTicks(5229), "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(3150), "Master Employee", "Master", null, null });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(4647), "Yağ", null, null },
                    { 2, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(4649), "Hava", null, null },
                    { 3, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(4650), "Yanacaq", null, null },
                    { 4, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(4651), "Salon", null, null },
                    { 5, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(4652), "Filter", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(6075), "Benzin", null, null },
                    { 2, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(6077), "Qaz", null, null },
                    { 3, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(6078), "Dizel", null, null },
                    { 4, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(6079), "Elektro", null, null },
                    { 5, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(6081), "Hybrid", null, null },
                    { 6, null, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(6082), "Plug-in Hybrid", null, null }
                });

            migrationBuilder.InsertData(
                table: "Motors",
                columns: new[] { "Id", "EngineCapacity", "InsertedBy", "InsertedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7530), null, null },
                    { 2, 200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7534), null, null },
                    { 3, 300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7535), null, null },
                    { 4, 400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7536), null, null },
                    { 5, 500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7536), null, null },
                    { 6, 600m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7539), null, null },
                    { 7, 700m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7539), null, null },
                    { 8, 800m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7540), null, null },
                    { 9, 900m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7541), null, null },
                    { 10, 1000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7543), null, null },
                    { 11, 1100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7543), null, null },
                    { 12, 1200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7544), null, null },
                    { 13, 1300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7545), null, null },
                    { 14, 1400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7546), null, null },
                    { 15, 1500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7547), null, null },
                    { 16, 1600m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7547), null, null },
                    { 17, 1700m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7548), null, null },
                    { 18, 1800m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7550), null, null },
                    { 19, 1900m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7551), null, null },
                    { 20, 2000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7551), null, null },
                    { 21, 2100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7552), null, null },
                    { 22, 2200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7553), null, null },
                    { 23, 2300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7554), null, null },
                    { 24, 2400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7555), null, null },
                    { 25, 2500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7555), null, null },
                    { 26, 2600m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7556), null, null },
                    { 27, 2700m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7557), null, null },
                    { 28, 2800m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7558), null, null },
                    { 29, 2900m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7559), null, null },
                    { 30, 3000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7559), null, null },
                    { 31, 3100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7560), null, null },
                    { 32, 3200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7561), null, null },
                    { 33, 3300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7562), null, null },
                    { 34, 3400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7563), null, null },
                    { 35, 3500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7564), null, null },
                    { 36, 3600m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7565), null, null },
                    { 37, 3700m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7566), null, null },
                    { 38, 3800m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7567), null, null },
                    { 39, 3900m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7567), null, null },
                    { 40, 4000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7568), null, null },
                    { 41, 4100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7569), null, null },
                    { 42, 4200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7570), null, null },
                    { 43, 4300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7571), null, null },
                    { 44, 4400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7571), null, null },
                    { 45, 4500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7606), null, null },
                    { 46, 4600m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7607), null, null },
                    { 47, 4700m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7608), null, null },
                    { 48, 4800m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7609), null, null },
                    { 49, 4900m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7610), null, null },
                    { 50, 5000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7610), null, null },
                    { 51, 5100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7611), null, null },
                    { 52, 5200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7612), null, null },
                    { 53, 5300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7613), null, null },
                    { 54, 5400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7614), null, null },
                    { 55, 5500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7614), null, null },
                    { 56, 5600m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7615), null, null },
                    { 57, 5700m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7616), null, null },
                    { 58, 5800m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7617), null, null },
                    { 59, 5900m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7618), null, null },
                    { 60, 6000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7618), null, null },
                    { 61, 6100m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7619), null, null },
                    { 62, 6200m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7620), null, null },
                    { 63, 6300m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7621), null, null },
                    { 64, 6400m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7622), null, null },
                    { 65, 6500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7622), null, null },
                    { 66, 7000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7625), null, null },
                    { 67, 7500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7626), null, null },
                    { 68, 8000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7626), null, null },
                    { 69, 8500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7627), null, null },
                    { 70, 9000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7628), null, null },
                    { 71, 9500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7629), null, null },
                    { 72, 10000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7630), null, null },
                    { 73, 10500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7630), null, null },
                    { 74, 11000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7631), null, null },
                    { 75, 11500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7632), null, null },
                    { 76, 12000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7633), null, null },
                    { 77, 12500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7634), null, null },
                    { 78, 13000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7635), null, null },
                    { 79, 13500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7635), null, null },
                    { 80, 14000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7636), null, null },
                    { 81, 14500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7637), null, null },
                    { 82, 15000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7638), null, null },
                    { 83, 15500m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7639), null, null },
                    { 84, 16000m, 3, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(7639), null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9135), false, "Alpine", null, null },
                    { 2, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9137), false, "Bardahl", null, null },
                    { 3, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9139), false, "Mitanol", null, null },
                    { 4, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9140), false, "Eni", null, null },
                    { 5, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9142), false, "Ravenol", null, null },
                    { 6, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9143), false, "German Gold", null, null },
                    { 7, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9145), false, "SRS", null, null },
                    { 8, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9146), false, "Ams-Oil", null, null },
                    { 9, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9147), false, "Petro Canada", null, null },
                    { 10, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9149), false, "Eurolub", null, null },
                    { 11, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9151), false, "Motul", null, null },
                    { 12, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9152), false, "Addinol", null, null },
                    { 13, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9154), false, "Mobil", null, null },
                    { 14, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9155), false, "Shell", null, null },
                    { 15, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9157), false, "Total", null, null },
                    { 16, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9205), false, "Eneos", null, null },
                    { 17, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9207), false, "Opet", null, null },
                    { 18, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9208), false, "Meguin", null, null },
                    { 19, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9210), false, "Rowe", null, null },
                    { 20, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9211), false, "Lubex", null, null },
                    { 21, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9212), false, "North Sea", null, null },
                    { 22, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9214), false, "AGAT", null, null },
                    { 23, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9215), false, "Boost Oil", null, null },
                    { 24, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9217), false, "Liqui Moly", null, null },
                    { 25, 2, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9218), false, "Liqui Moly", null, null },
                    { 26, 3, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(9220), false, "Opet", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(1430), false, "Costumer", null, null },
                    { 2, null, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(1432), false, "Branch", null, null }
                });

            migrationBuilder.InsertData(
                table: "SAEViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(2594), false, null, null },
                    { 2, 5, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(2596), false, null, null },
                    { 3, 10, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(2597), false, null, null },
                    { 4, 20, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(2599), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4069), "Sürətlər qutusu yağ dəyişmə", null, null },
                    { 2, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4072), "Mühərrik yağ dəyişmə", null, null },
                    { 3, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4073), "Antifiriz dəyişmə", null, null },
                    { 4, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4074), "Əyləc mayesi dəyişmə", null, null },
                    { 5, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4076), "Arxa körpü", null, null },
                    { 6, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4077), "Ön körpü", null, null },
                    { 7, 1, new DateTime(2025, 2, 12, 23, 13, 1, 809, DateTimeKind.Local).AddTicks(4078), "Diferensial (Razdatka)", null, null }
                });

            migrationBuilder.InsertData(
                table: "WinterViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "ServiceType", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 8m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9935), false, 1, null, null },
                    { 2, 12m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9937), false, 1, null, null },
                    { 3, 16m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9938), false, 1, null, null },
                    { 4, 20m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9940), false, 1, null, null },
                    { 5, 30m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9942), false, 1, null, null },
                    { 6, 40m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9943), false, 1, null, null },
                    { 7, 50m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9945), false, 1, null, null },
                    { 8, 60m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9946), false, 1, null, null },
                    { 9, 3m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9947), false, 2, null, null },
                    { 10, 4m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9949), false, 2, null, null },
                    { 11, 5.1m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9952), false, 2, null, null },
                    { 12, 6m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9953), false, 2, null, null },
                    { 13, 5m, 1, new DateTime(2025, 2, 12, 23, 13, 1, 810, DateTimeKind.Local).AddTicks(9955), false, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsOtp", "Name", "NotificationToken", "OtpCode", "OtpExpirationTime", "Password", "Phone", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(1623), true, "Master Admin", null, null, null, "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K", "+994000", "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=", new DateTime(2025, 4, 12, 23, 13, 1, 804, DateTimeKind.Local).AddTicks(1603), 2, "Master", null, null });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "BranchId", "InsertedBy", "InsertedDate", "IsDeleted", "Phone", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7274), false, "+994703305788", null, null },
                    { 2, 2, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7277), false, "+994702343134", null, null },
                    { 3, 3, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7278), false, "+994706843434", null, null },
                    { 4, 4, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7280), false, "+994777332322", null, null },
                    { 5, 5, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7281), false, "+994706743434", null, null },
                    { 6, 6, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7283), false, "+994707552322", null, null },
                    { 7, 7, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7284), false, "+994702153434", null, null },
                    { 8, 8, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7285), false, "+994702344334", null, null },
                    { 9, 9, 1, new DateTime(2025, 2, 12, 23, 13, 1, 808, DateTimeKind.Local).AddTicks(7287), false, "+994702344334", null, null }
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
                name: "Notifications");

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
