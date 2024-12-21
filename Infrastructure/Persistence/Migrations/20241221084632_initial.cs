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
                    OTPCode = table.Column<int>(type: "int", nullable: true),
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
                    SAEViscosityId = table.Column<int>(type: "int", nullable: true),
                    WinterViscosityId = table.Column<int>(type: "int", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KilometersTravelled = table.Column<int>(type: "int", nullable: true),
                    OilVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "Address", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "General Şixlinski küçəsi,264 saylı məktəbin yanı", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6544), "Əhmədli filialı", null, null },
                    { 2, "Şeyx Məhəmməd Xiyabani 51", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6547), "Yasamal filialı", null, null },
                    { 3, "Binəqədi şosesi 1. Binəqədi 4yol", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6549), "Binəqədi filialı", null, null },
                    { 4, "Yavər Əliyev 68A", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6550), "Bakıxanov filialı", null, null },
                    { 5, "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6551), "Xətai filialı", null, null },
                    { 6, "Sumqayıt-çerkasski 78", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6552), "Sumqayıt filialı", null, null },
                    { 7, "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6554), "Gəncə filialı", null, null },
                    { 8, "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6555), "Xaçmaz filialı", null, null },
                    { 9, "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(6556), "Quba filialı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8464), "X5", null, null },
                    { 2, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8466), "M3", null, null },
                    { 3, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8467), "M4", null, null },
                    { 4, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8469), "M2", null, null },
                    { 5, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8471), "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8472), "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8473), "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8474), "X3", null, null },
                    { 9, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8476), "X4", null, null },
                    { 10, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8477), "X6", null, null },
                    { 11, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8478), "X7", null, null },
                    { 12, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8480), "i3", null, null },
                    { 13, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8481), "i4", null, null },
                    { 14, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8482), "iX", null, null },
                    { 15, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8483), "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8484), "530e", null, null },
                    { 17, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8485), "750i", null, null },
                    { 18, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8487), "M5", null, null },
                    { 19, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8488), "M8", null, null },
                    { 20, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8489), "i7", null, null },
                    { 21, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8490), "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8491), "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8492), "M6", null, null },
                    { 24, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8494), "320i", null, null },
                    { 25, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8495), "420i", null, null },
                    { 26, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8497), "520d", null, null },
                    { 27, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8498), "730d", null, null },
                    { 28, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8499), "740i", null, null },
                    { 29, "BMW", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8500), "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8501), "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8548), "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8549), "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8550), "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8552), "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8553), "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8554), "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8555), "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8556), "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8558), "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8559), "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8560), "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8561), "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8562), "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8564), "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8565), "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8567), "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8568), "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8569), "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8570), "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8571), "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8573), "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8574), "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8575), "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8576), "A4", null, null },
                    { 55, "Audi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8577), "A6", null, null },
                    { 56, "Audi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8579), "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8580), "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8581), "A8", null, null },
                    { 59, "Audi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8582), "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8583), "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8585), "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8586), "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8587), "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8588), "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8590), "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8591), "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8593), "K5", null, null },
                    { 68, "Kia", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8594), "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8595), "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8596), "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8597), "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8599), "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8600), "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8601), "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8602), "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8603), "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8605), "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8606), "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8607), "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8608), "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8609), "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8610), "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8611), "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8613), "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8614), "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8615), "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8616), "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8617), "911", null, null },
                    { 89, "Porsche", null, new DateTime(2024, 12, 21, 12, 46, 31, 774, DateTimeKind.Local).AddTicks(8618), "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(407), "Ağ", null, null },
                    { 2, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(462), "Qara", null, null },
                    { 3, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(464), "Qırmızı", null, null },
                    { 4, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(465), "Yaşıl", null, null },
                    { 5, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(466), "Mavi", null, null },
                    { 6, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(466), "Sarı", null, null },
                    { 7, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(468), "Narıncı", null, null },
                    { 8, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(469), "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(470), "Çəhrayı", null, null },
                    { 10, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(471), "Boz", null, null },
                    { 11, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(472), "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(472), "Göy", null, null },
                    { 13, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(473), "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(474), "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(474), "Tünd mavi", null, null },
                    { 16, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(475), "Açıq mavi", null, null },
                    { 17, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(476), "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(476), "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(477), "Bürünc", null, null },
                    { 20, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(478), "Gümüşü", null, null },
                    { 21, null, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(479), "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(9088), "Master Employee", "Master", null, null });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(686), "Yağ", null, null },
                    { 2, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(688), "Hava", null, null },
                    { 3, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(689), "Yanacaq", null, null },
                    { 4, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(690), "Salon", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(2282), "Benzin", null, null },
                    { 2, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(2284), "Qaz", null, null },
                    { 3, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(2286), "Dizel", null, null },
                    { 4, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(2287), "Elektro", null, null },
                    { 5, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(2288), "Hybrid", null, null },
                    { 6, null, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(2289), "Plug-in Hybrid", null, null }
                });

            migrationBuilder.InsertData(
                table: "Motors",
                columns: new[] { "Id", "EngineCapacity", "InsertedBy", "InsertedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3889), null, null },
                    { 2, 200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3893), null, null },
                    { 3, 300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3894), null, null },
                    { 4, 400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3895), null, null },
                    { 5, 500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3896), null, null },
                    { 6, 600m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3898), null, null },
                    { 7, 700m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3899), null, null },
                    { 8, 800m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3900), null, null },
                    { 9, 900m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3901), null, null },
                    { 10, 1000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3903), null, null },
                    { 11, 1100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3968), null, null },
                    { 12, 1200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3969), null, null },
                    { 13, 1300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3970), null, null },
                    { 14, 1400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3971), null, null },
                    { 15, 1500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3972), null, null },
                    { 16, 1600m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3973), null, null },
                    { 17, 1700m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3973), null, null },
                    { 18, 1800m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3975), null, null },
                    { 19, 1900m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3976), null, null },
                    { 20, 2000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3977), null, null },
                    { 21, 2100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3978), null, null },
                    { 22, 2200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3979), null, null },
                    { 23, 2300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3980), null, null },
                    { 24, 2400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3981), null, null },
                    { 25, 2500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3982), null, null },
                    { 26, 2600m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3982), null, null },
                    { 27, 2700m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3983), null, null },
                    { 28, 2800m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3984), null, null },
                    { 29, 2900m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3985), null, null },
                    { 30, 3000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3986), null, null },
                    { 31, 3100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3987), null, null },
                    { 32, 3200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3988), null, null },
                    { 33, 3300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3988), null, null },
                    { 34, 3400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3990), null, null },
                    { 35, 3500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3991), null, null },
                    { 36, 3600m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3992), null, null },
                    { 37, 3700m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3992), null, null },
                    { 38, 3800m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3993), null, null },
                    { 39, 3900m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3994), null, null },
                    { 40, 4000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3995), null, null },
                    { 41, 4100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3996), null, null },
                    { 42, 4200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3997), null, null },
                    { 43, 4300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3998), null, null },
                    { 44, 4400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3998), null, null },
                    { 45, 4500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(3999), null, null },
                    { 46, 4600m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4000), null, null },
                    { 47, 4700m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4001), null, null },
                    { 48, 4800m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4002), null, null },
                    { 49, 4900m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4003), null, null },
                    { 50, 5000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4004), null, null },
                    { 51, 5100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4005), null, null },
                    { 52, 5200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4006), null, null },
                    { 53, 5300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4006), null, null },
                    { 54, 5400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4007), null, null },
                    { 55, 5500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4008), null, null },
                    { 56, 5600m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4009), null, null },
                    { 57, 5700m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4010), null, null },
                    { 58, 5800m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4011), null, null },
                    { 59, 5900m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4012), null, null },
                    { 60, 6000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4012), null, null },
                    { 61, 6100m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4013), null, null },
                    { 62, 6200m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4014), null, null },
                    { 63, 6300m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4015), null, null },
                    { 64, 6400m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4016), null, null },
                    { 65, 6500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4017), null, null },
                    { 66, 6500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4019), null, null },
                    { 67, 7000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4021), null, null },
                    { 68, 7500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4021), null, null },
                    { 69, 8000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4022), null, null },
                    { 70, 8500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4023), null, null },
                    { 71, 9000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4024), null, null },
                    { 72, 9500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4025), null, null },
                    { 73, 10000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4026), null, null },
                    { 74, 10500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4027), null, null },
                    { 75, 11000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4028), null, null },
                    { 76, 11500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4028), null, null },
                    { 77, 12000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4029), null, null },
                    { 78, 12500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4030), null, null },
                    { 79, 13000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4031), null, null },
                    { 80, 13500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4032), null, null },
                    { 81, 14000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4033), null, null },
                    { 82, 14500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4033), null, null },
                    { 83, 15000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4069), null, null },
                    { 84, 15500m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4071), null, null },
                    { 85, 16000m, 3, new DateTime(2024, 12, 21, 12, 46, 31, 776, DateTimeKind.Local).AddTicks(4072), null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(2900), false, "Elf", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(4336), false, "Costumer", null, null },
                    { 2, null, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(4338), false, "Branch", null, null }
                });

            migrationBuilder.InsertData(
                table: "SAEViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(5576), false, null, null },
                    { 2, 5, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(5578), false, null, null },
                    { 3, 10, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(5579), false, null, null },
                    { 4, 20, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(5581), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7219), "Sürətlər qutusu yağ dəyişmə", null, null },
                    { 2, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7222), "Mühərrik yağ dəyişmə", null, null },
                    { 3, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7223), "Antifiriz dəyişmə", null, null },
                    { 4, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7225), "Əyləc mayesi dəyişmə", null, null },
                    { 5, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7226), "Arxa körpü", null, null },
                    { 6, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7227), "Ön körpü", null, null },
                    { 7, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(7228), "Diferensial (Razdatka)", null, null }
                });

            migrationBuilder.InsertData(
                table: "WinterViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "ServiceType", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 8m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1855), false, 1, null, null },
                    { 2, 12m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1858), false, 1, null, null },
                    { 3, 16m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1860), false, 1, null, null },
                    { 4, 20m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1861), false, 1, null, null },
                    { 5, 30m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1863), false, 1, null, null },
                    { 6, 40m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1864), false, 1, null, null },
                    { 7, 50m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1866), false, 1, null, null },
                    { 8, 60m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1867), false, 1, null, null },
                    { 9, 3m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1869), false, 2, null, null },
                    { 10, 4m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1870), false, 2, null, null },
                    { 11, 5.1m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1873), false, 2, null, null },
                    { 12, 6m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1874), false, 2, null, null },
                    { 13, 5m, 1, new DateTime(2024, 12, 21, 12, 46, 31, 782, DateTimeKind.Local).AddTicks(1876), false, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsOtp", "Name", "OTPCode", "Password", "Phone", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(7412), true, "Master Admin", null, "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K", "+994000", "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=", new DateTime(2025, 2, 21, 12, 46, 31, 775, DateTimeKind.Local).AddTicks(7394), 2, "Master", null, null });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "BranchId", "InsertedBy", "InsertedDate", "IsDeleted", "Phone", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1552), false, "+994703305788", null, null },
                    { 2, 2, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1555), false, "+994702343134", null, null },
                    { 3, 2, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1557), false, "+994706843434", null, null },
                    { 4, 4, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1558), false, "+994777332322", null, null },
                    { 5, 4, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1560), false, "+994706743434", null, null },
                    { 6, 3, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1561), false, "+994707552322", null, null },
                    { 7, 3, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1563), false, "+994702153434", null, null },
                    { 8, 3, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1564), false, "+994702344334", null, null },
                    { 9, 3, 1, new DateTime(2024, 12, 21, 12, 46, 31, 780, DateTimeKind.Local).AddTicks(1565), false, "+994702344334", null, null }
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
