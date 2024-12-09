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
                name: "OilTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InsertedBy = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Motor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    ColorsId = table.Column<int>(type: "int", nullable: true),
                    FuelTypeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_CustomersCarsMatrix_Colors_CarId",
                        column: x => x.CarId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id");
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
                    OilTypeId = table.Column<int>(type: "int", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KilometersTravelled = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
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
                    { 1, "Əhmədli filialı", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(4506), "Əhmədli", null, null },
                    { 2, "Yasamal filialı", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(4511), "Yasamal", null, null },
                    { 3, "Sumqayıt filialı", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(4513), "Sumqayıt", null, null },
                    { 4, "Bakıxanov filialı", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(4514), "Bakıxanov", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7187), "X5", null, null },
                    { 2, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7190), "M3", null, null },
                    { 3, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7192), "M4", null, null },
                    { 4, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7194), "M2", null, null },
                    { 5, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7196), "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7198), "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7199), "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7201), "X3", null, null },
                    { 9, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7203), "X4", null, null },
                    { 10, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7205), "X6", null, null },
                    { 11, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7206), "X7", null, null },
                    { 12, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7208), "i3", null, null },
                    { 13, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7210), "i4", null, null },
                    { 14, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7212), "iX", null, null },
                    { 15, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7213), "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7215), "530e", null, null },
                    { 17, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7217), "750i", null, null },
                    { 18, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7219), "M5", null, null },
                    { 19, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7222), "M8", null, null },
                    { 20, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7223), "i7", null, null },
                    { 21, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7225), "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7227), "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7229), "M6", null, null },
                    { 24, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7231), "320i", null, null },
                    { 25, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7232), "420i", null, null },
                    { 26, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7295), "520d", null, null },
                    { 27, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7297), "730d", null, null },
                    { 28, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7299), "740i", null, null },
                    { 29, "BMW", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7301), "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7303), "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7305), "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7307), "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7309), "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7311), "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7312), "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7314), "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7316), "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7318), "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7321), "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7322), "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7324), "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7326), "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7327), "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7329), "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7331), "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7333), "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7335), "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7336), "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7338), "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7340), "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7342), "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7344), "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7346), "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7347), "A4", null, null },
                    { 55, "Audi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7351), "A6", null, null },
                    { 56, "Audi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7353), "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7355), "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7356), "A8", null, null },
                    { 59, "Audi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7358), "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7361), "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7362), "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7364), "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7366), "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7368), "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7370), "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7372), "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7373), "K5", null, null },
                    { 68, "Kia", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7375), "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7377), "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7379), "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7380), "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7382), "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7384), "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7386), "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7388), "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7390), "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7392), "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7394), "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7395), "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7397), "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7399), "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7401), "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7403), "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7404), "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7406), "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7408), "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7410), "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7411), "911", null, null },
                    { 89, "Porsche", null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(7413), "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9839), "Ağ", null, null },
                    { 2, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9845), "Qara", null, null },
                    { 3, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9846), "Qırmızı", null, null },
                    { 4, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9848), "Yaşıl", null, null },
                    { 5, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9849), "Mavi", null, null },
                    { 6, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9850), "Sarı", null, null },
                    { 7, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9851), "Narıncı", null, null },
                    { 8, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9852), "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9855), "Çəhrayı", null, null },
                    { 10, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9856), "Boz", null, null },
                    { 11, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9857), "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9858), "Göy", null, null },
                    { 13, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9859), "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9860), "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9861), "Tünd mavi", null, null },
                    { 16, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9863), "Açıq mavi", null, null },
                    { 17, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9863), "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9864), "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9865), "Bürünc", null, null },
                    { 20, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9867), "Gümüşü", null, null },
                    { 21, null, new DateTime(2024, 12, 9, 22, 17, 22, 346, DateTimeKind.Local).AddTicks(9867), "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(1420), "Master Employee", "Master", null, null });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(3708), "Yağ", null, null },
                    { 2, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(3710), "Hava", null, null },
                    { 3, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(3712), "Yanacaq", null, null },
                    { 4, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(3714), "Salon", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6080), "Benzin", null, null },
                    { 2, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6083), "Qaz", null, null },
                    { 3, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6085), "Dizel", null, null },
                    { 4, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6086), "Elektro", null, null },
                    { 5, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6088), "Hybrid", null, null },
                    { 6, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6090), "Plug-in Hybrid", null, null },
                    { 7, null, new DateTime(2024, 12, 9, 22, 17, 22, 348, DateTimeKind.Local).AddTicks(6092), "Hidrogen", null, null }
                });

            migrationBuilder.InsertData(
                table: "OilTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 9, 22, 17, 22, 353, DateTimeKind.Local).AddTicks(3120), false, "5-30", null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2024, 12, 9, 22, 17, 22, 354, DateTimeKind.Local).AddTicks(779), false, "Elf", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 9, 22, 17, 22, 354, DateTimeKind.Local).AddTicks(2508), false, "Costumer", null, null },
                    { 2, null, new DateTime(2024, 12, 9, 22, 17, 22, 354, DateTimeKind.Local).AddTicks(2511), false, "Branch", null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 9, 22, 17, 22, 354, DateTimeKind.Local).AddTicks(4825), "Sürətlər qutusu yağ dəyişmə", null, null },
                    { 2, 1, new DateTime(2024, 12, 9, 22, 17, 22, 354, DateTimeKind.Local).AddTicks(4828), "Mühərrik yağ dəyişmə", null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Password", "Phone", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 9, 22, 17, 22, 347, DateTimeKind.Local).AddTicks(9039), "Master Admin", "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K", "+994000", "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=", new DateTime(2025, 2, 9, 22, 17, 22, 347, DateTimeKind.Local).AddTicks(9017), 2, "Master", null, null });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "BranchId", "InsertedBy", "InsertedDate", "IsDeleted", "Phone", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 12, 9, 22, 17, 22, 353, DateTimeKind.Local).AddTicks(8897), false, "+994703305788", null, null },
                    { 2, 2, 1, new DateTime(2024, 12, 9, 22, 17, 22, 353, DateTimeKind.Local).AddTicks(8901), false, "+994702343134", null, null },
                    { 3, 3, 1, new DateTime(2024, 12, 9, 22, 17, 22, 353, DateTimeKind.Local).AddTicks(8903), false, "+994707552322", null, null },
                    { 4, 4, 1, new DateTime(2024, 12, 9, 22, 17, 22, 353, DateTimeKind.Local).AddTicks(8906), false, "+994077332322", null, null }
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
                name: "IX_CustomersCarsMatrix_CustomerId",
                table: "CustomersCarsMatrix",
                column: "CustomerId");

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
                name: "IX_OilChanges_CustomersCarsMatrixId",
                table: "OilChanges",
                column: "CustomersCarsMatrixId");

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
                name: "OilTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
