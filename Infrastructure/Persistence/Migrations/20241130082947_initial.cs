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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OilTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    BranchiesId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Branchies_BranchiesId",
                        column: x => x.BranchiesId,
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
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                    CustumerId = table.Column<int>(type: "int", nullable: false),
                    CarNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Motor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    ColorsId = table.Column<int>(type: "int", nullable: true),
                    FuelTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                        name: "FK_CustomersCarsMatrix_Customers_CustumerId",
                        column: x => x.CustumerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersCarsMatrix_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OilChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustumerId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OilTypeId = table.Column<int>(type: "int", nullable: false),
                    LitersUsed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KilometersTravelled = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                        name: "FK_OilChanges_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Customers_CustumerId",
                        column: x => x.CustumerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_OilTypes_OilTypeId",
                        column: x => x.OilTypeId,
                        principalTable: "OilTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilChanges_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<TimeSpan>(type: "time", nullable: true)
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
                columns: new[] { "Id", "Address", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Əhmədli filialı", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(200), false, "Əhmədli", null, null },
                    { 2, "Yasamal filialı", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(219), false, "Yasamal", null, null },
                    { 3, "Sumqayıt filialı", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(221), false, "Sumqayıt", null, null },
                    { 4, "Bakıxanov filialı", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(289), false, "Bakıxanov", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "IsDeleted", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2348), false, "X5", null, null },
                    { 2, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2353), false, "M3", null, null },
                    { 3, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2355), false, "M4", null, null },
                    { 4, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2357), false, "M2", null, null },
                    { 5, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2360), false, "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2362), false, "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2364), false, "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2366), false, "X3", null, null },
                    { 9, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2368), false, "X4", null, null },
                    { 10, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2370), false, "X6", null, null },
                    { 11, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2372), false, "X7", null, null },
                    { 12, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2374), false, "i3", null, null },
                    { 13, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2376), false, "i4", null, null },
                    { 14, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2378), false, "iX", null, null },
                    { 15, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2381), false, "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2383), false, "530e", null, null },
                    { 17, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2385), false, "750i", null, null },
                    { 18, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2387), false, "M5", null, null },
                    { 19, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2389), false, "M8", null, null },
                    { 20, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2455), false, "i7", null, null },
                    { 21, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2457), false, "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2460), false, "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2462), false, "M6", null, null },
                    { 24, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2464), false, "320i", null, null },
                    { 25, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2466), false, "420i", null, null },
                    { 26, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2468), false, "520d", null, null },
                    { 27, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2470), false, "730d", null, null },
                    { 28, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2472), false, "740i", null, null },
                    { 29, "BMW", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2474), false, "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2478), false, "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2480), false, "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2482), false, "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2484), false, "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2486), false, "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2488), false, "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2490), false, "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2492), false, "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2494), false, "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2496), false, "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2498), false, "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2500), false, "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2502), false, "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2504), false, "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2506), false, "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2508), false, "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2510), false, "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2512), false, "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2514), false, "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2516), false, "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2518), false, "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2520), false, "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2522), false, "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2524), false, "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2526), false, "A4", null, null },
                    { 55, "Audi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2528), false, "A6", null, null },
                    { 56, "Audi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2530), false, "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2532), false, "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2534), false, "A8", null, null },
                    { 59, "Audi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2537), false, "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2539), false, "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2541), false, "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2543), false, "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2545), false, "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2547), false, "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2550), false, "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2553), false, "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2555), false, "K5", null, null },
                    { 68, "Kia", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2557), false, "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2559), false, "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2561), false, "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2563), false, "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2565), false, "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2568), false, "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2570), false, "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2571), false, "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2573), false, "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2575), false, "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2577), false, "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2579), false, "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2581), false, "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2583), false, "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2585), false, "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2587), false, "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2733), false, "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2736), false, "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2738), false, "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2741), false, "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2743), false, "911", null, null },
                    { 89, "Porsche", null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(2745), false, "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4623), false, "Ağ", null, null },
                    { 2, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4628), false, "Qara", null, null },
                    { 3, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4630), false, "Qırmızı", null, null },
                    { 4, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4631), false, "Yaşıl", null, null },
                    { 5, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4632), false, "Mavi", null, null },
                    { 6, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4634), false, "Sarı", null, null },
                    { 7, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4636), false, "Narıncı", null, null },
                    { 8, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4637), false, "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4638), false, "Çəhrayı", null, null },
                    { 10, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4639), false, "Boz", null, null },
                    { 11, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4640), false, "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4641), false, "Göy", null, null },
                    { 13, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4643), false, "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4644), false, "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4645), false, "Tünd mavi", null, null },
                    { 16, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4646), false, "Açıq mavi", null, null },
                    { 17, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4648), false, "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4649), false, "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4650), false, "Bürünc", null, null },
                    { 20, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4652), false, "Gümüşü", null, null },
                    { 21, null, new DateTime(2024, 11, 30, 12, 29, 46, 791, DateTimeKind.Local).AddTicks(4654), false, "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(8017), false, "Yağ", null, null },
                    { 2, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(8025), false, "Hava", null, null },
                    { 3, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(8026), false, "Yanacaq", null, null },
                    { 4, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(8027), false, "Salon", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9797), false, "Benzin", null, null },
                    { 2, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9802), false, "Qaz", null, null },
                    { 3, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9804), false, "Dizel", null, null },
                    { 4, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9805), false, "Elektro", null, null },
                    { 5, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9807), false, "Hybrid", null, null },
                    { 6, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9808), false, "Plug-in Hybrid", null, null },
                    { 7, null, new DateTime(2024, 11, 30, 12, 29, 46, 792, DateTimeKind.Local).AddTicks(9809), false, "Hidrogen", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 30, 12, 29, 46, 802, DateTimeKind.Local).AddTicks(1323), false, "Costumer", null, null },
                    { 2, null, new DateTime(2024, 11, 30, 12, 29, 46, 802, DateTimeKind.Local).AddTicks(1329), false, "Branch", null, null }
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
                name: "IX_CustomersCarsMatrix_CustumerId",
                table: "CustomersCarsMatrix",
                column: "CustumerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersCarsMatrix_FuelTypeId",
                table: "CustomersCarsMatrix",
                column: "FuelTypeId");

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
                name: "IX_OilChanges_CarId",
                table: "OilChanges",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_CustumerId",
                table: "OilChanges",
                column: "CustumerId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_EmployeeId",
                table: "OilChanges",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_OilTypeId",
                table: "OilChanges",
                column: "OilTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_ProductId",
                table: "OilChanges",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OilChanges_ServiceId",
                table: "OilChanges",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_BranchiesId",
                table: "Phones",
                column: "BranchiesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commits");

            migrationBuilder.DropTable(
                name: "CustomersCarsMatrix");

            migrationBuilder.DropTable(
                name: "OilChangeFiltersMatrix");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "OilChanges");

            migrationBuilder.DropTable(
                name: "Branchies");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OilTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
