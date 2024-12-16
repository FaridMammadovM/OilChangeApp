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
                    Motor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    ColorsId = table.Column<int>(type: "int", nullable: true),
                    FuelTypeId = table.Column<int>(type: "int", nullable: true),
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
                    { 1, "General Şixlinski küçəsi,264 saylı məktəbin yanı", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2350), "Əhmədli filialı", null, null },
                    { 2, "Şeyx Məhəmməd Xiyabani 51", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2354), "Yasamal filialı", null, null },
                    { 3, "Binəqədi şosesi 1. Binəqədi 4yol", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2356), "Binəqədi filialı", null, null },
                    { 4, "Yavər Əliyev 68A", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2357), "Bakıxanov filialı", null, null },
                    { 5, "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2359), "Xətai filialı", null, null },
                    { 6, "Sumqayıt-çerkasski 78", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2361), "Sumqayıt filialı", null, null },
                    { 7, "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2362), "Gəncə filialı", null, null },
                    { 8, "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2364), "Xaçmaz filialı", null, null },
                    { 9, "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(2388), "Quba filialı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4939), "X5", null, null },
                    { 2, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4941), "M3", null, null },
                    { 3, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4943), "M4", null, null },
                    { 4, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4945), "M2", null, null },
                    { 5, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4947), "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4949), "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4951), "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4952), "X3", null, null },
                    { 9, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4954), "X4", null, null },
                    { 10, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4956), "X6", null, null },
                    { 11, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4957), "X7", null, null },
                    { 12, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4959), "i3", null, null },
                    { 13, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4961), "i4", null, null },
                    { 14, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4963), "iX", null, null },
                    { 15, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4965), "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4967), "530e", null, null },
                    { 17, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4968), "750i", null, null },
                    { 18, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4970), "M5", null, null },
                    { 19, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4972), "M8", null, null },
                    { 20, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4974), "i7", null, null },
                    { 21, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4976), "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4977), "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4979), "M6", null, null },
                    { 24, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4981), "320i", null, null },
                    { 25, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4982), "420i", null, null },
                    { 26, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4984), "520d", null, null },
                    { 27, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4986), "730d", null, null },
                    { 28, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4987), "740i", null, null },
                    { 29, "BMW", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4989), "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4991), "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4992), "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4994), "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4996), "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(4998), "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5000), "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5002), "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5003), "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5005), "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5007), "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5008), "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5010), "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5011), "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5013), "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5015), "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5016), "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5018), "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5020), "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5021), "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5023), "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5024), "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5026), "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5027), "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5029), "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5031), "A4", null, null },
                    { 55, "Audi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5033), "A6", null, null },
                    { 56, "Audi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5035), "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5036), "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5038), "A8", null, null },
                    { 59, "Audi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5099), "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5102), "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5103), "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5105), "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5107), "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5109), "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5110), "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5112), "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5114), "K5", null, null },
                    { 68, "Kia", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5115), "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5117), "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5119), "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5120), "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5122), "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5123), "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5125), "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5127), "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5129), "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5130), "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5132), "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5133), "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5135), "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5137), "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5138), "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5140), "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5142), "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5143), "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5145), "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5147), "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5149), "911", null, null },
                    { 89, "Porsche", null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(5150), "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7368), "Ağ", null, null },
                    { 2, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7374), "Qara", null, null },
                    { 3, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7375), "Qırmızı", null, null },
                    { 4, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7377), "Yaşıl", null, null },
                    { 5, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7378), "Mavi", null, null },
                    { 6, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7379), "Sarı", null, null },
                    { 7, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7380), "Narıncı", null, null },
                    { 8, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7381), "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7382), "Çəhrayı", null, null },
                    { 10, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7384), "Boz", null, null },
                    { 11, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7385), "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7386), "Göy", null, null },
                    { 13, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7387), "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7388), "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7389), "Tünd mavi", null, null },
                    { 16, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7390), "Açıq mavi", null, null },
                    { 17, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7390), "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7391), "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7392), "Bürünc", null, null },
                    { 20, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7393), "Gümüşü", null, null },
                    { 21, null, new DateTime(2024, 12, 16, 22, 51, 42, 228, DateTimeKind.Local).AddTicks(7394), "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 16, 22, 51, 42, 229, DateTimeKind.Local).AddTicks(8330), "Master Employee", "Master", null, null });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(438), "Yağ", null, null },
                    { 2, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(441), "Hava", null, null },
                    { 3, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(442), "Yanacaq", null, null },
                    { 4, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(444), "Salon", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(2570), "Benzin", null, null },
                    { 2, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(2573), "Qaz", null, null },
                    { 3, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(2574), "Dizel", null, null },
                    { 4, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(2576), "Elektro", null, null },
                    { 5, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(2578), "Hybrid", null, null },
                    { 6, null, new DateTime(2024, 12, 16, 22, 51, 42, 230, DateTimeKind.Local).AddTicks(2579), "Plug-in Hybrid", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(2803), false, "Elf", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(4586), false, "Costumer", null, null },
                    { 2, null, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(4588), false, "Branch", null, null }
                });

            migrationBuilder.InsertData(
                table: "SAEViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(6174), false, null, null },
                    { 2, 5, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(6177), false, null, null },
                    { 3, 10, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(6179), false, null, null },
                    { 4, 20, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(6181), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8281), "Sürətlər qutusu yağ dəyişmə", null, null },
                    { 2, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8284), "Mühərrik yağ dəyişmə", null, null },
                    { 3, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8286), "Antifiriz dəyişmə", null, null },
                    { 4, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8288), "Əyləc mayesi dəyişmə", null, null },
                    { 5, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8290), "Arxa körpü", null, null },
                    { 6, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8292), "Ön körpü", null, null },
                    { 7, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(8294), "Diferensial (Razdatka)", null, null }
                });

            migrationBuilder.InsertData(
                table: "WinterViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsBrakeFluidChanged", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 8m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6967), false, false, null, null },
                    { 2, 12m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6970), false, false, null, null },
                    { 3, 16m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6972), false, false, null, null },
                    { 4, 20m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6975), false, false, null, null },
                    { 5, 30m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6977), false, false, null, null },
                    { 6, 40m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6979), false, false, null, null },
                    { 7, 50m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6981), false, false, null, null },
                    { 8, 60m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6983), false, false, null, null },
                    { 9, 3m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6985), true, false, null, null },
                    { 10, 4m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6987), true, false, null, null },
                    { 11, 5.1m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6990), true, false, null, null },
                    { 12, 6m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6992), true, false, null, null },
                    { 13, 5m, 1, new DateTime(2024, 12, 16, 22, 51, 42, 237, DateTimeKind.Local).AddTicks(6994), true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsOtp", "Name", "Password", "Phone", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 16, 22, 51, 42, 229, DateTimeKind.Local).AddTicks(6057), false, "Master Admin", "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K", "+994000", "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=", new DateTime(2025, 2, 16, 22, 51, 42, 229, DateTimeKind.Local).AddTicks(6036), 2, "Master", null, null });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "BranchId", "InsertedBy", "InsertedDate", "IsDeleted", "Phone", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1007), false, "+994703305788", null, null },
                    { 2, 2, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1010), false, "+994702343134", null, null },
                    { 3, 2, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1012), false, "+994706843434", null, null },
                    { 4, 4, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1045), false, "+994777332322", null, null },
                    { 5, 4, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1047), false, "+994706743434", null, null },
                    { 6, 3, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1049), false, "+994707552322", null, null },
                    { 7, 3, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1051), false, "+994702153434", null, null },
                    { 8, 3, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1053), false, "+994702344334", null, null },
                    { 9, 3, 1, new DateTime(2024, 12, 16, 22, 51, 42, 235, DateTimeKind.Local).AddTicks(1055), false, "+994702344334", null, null }
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
                name: "Roles");
        }
    }
}
