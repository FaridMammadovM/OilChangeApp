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
                    { 1, "General Şixlinski küçəsi,264 saylı məktəbin yanı", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8115), "Əhmədli filialı", null, null },
                    { 2, "Şeyx Məhəmməd Xiyabani 51", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8117), "Yasamal filialı", null, null },
                    { 3, "Binəqədi şosesi 1. Binəqədi 4yol", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8119), "Binəqədi filialı", null, null },
                    { 4, "Yavər Əliyev 68A", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8120), "Bakıxanov filialı", null, null },
                    { 5, "Xətai-8 noyabr prospekti, günəş petrol ydm-in içi", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8121), "Xətai filialı", null, null },
                    { 6, "Sumqayıt-çerkasski 78", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8122), "Sumqayıt filialı", null, null },
                    { 7, "Gəncə şəhəri, Əli Məmmədov küçəsi (3 Nömrəli xəstəxananın yanı)", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8123), "Gəncə filialı", null, null },
                    { 8, "Xaçmaz şeheri Xacmaz Xudat yolu Qımıl restoranın yanı", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8125), "Xaçmaz filialı", null, null },
                    { 9, "Quba rayonu Heyder Eliyev prospekti Praqa restoranin yani", null, new DateTime(2024, 12, 18, 23, 8, 2, 627, DateTimeKind.Local).AddTicks(8126), "Quba filialı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "InsertedBy", "InsertedDate", "Model", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(501), "X5", null, null },
                    { 2, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(503), "M3", null, null },
                    { 3, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(505), "M4", null, null },
                    { 4, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(506), "M2", null, null },
                    { 5, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(507), "3 Series", null, null },
                    { 6, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(509), "5 Series", null, null },
                    { 7, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(510), "7 Series", null, null },
                    { 8, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(511), "X3", null, null },
                    { 9, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(513), "X4", null, null },
                    { 10, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(514), "X6", null, null },
                    { 11, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(515), "X7", null, null },
                    { 12, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(516), "i3", null, null },
                    { 13, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(517), "i4", null, null },
                    { 14, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(518), "iX", null, null },
                    { 15, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(520), "Z4", null, null },
                    { 16, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(521), "530e", null, null },
                    { 17, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(522), "750i", null, null },
                    { 18, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(523), "M5", null, null },
                    { 19, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(524), "M8", null, null },
                    { 20, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(525), "i7", null, null },
                    { 21, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(527), "2 Series", null, null },
                    { 22, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(528), "1 Series", null, null },
                    { 23, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(529), "M6", null, null },
                    { 24, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(530), "320i", null, null },
                    { 25, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(532), "420i", null, null },
                    { 26, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(533), "520d", null, null },
                    { 27, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(534), "730d", null, null },
                    { 28, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(535), "740i", null, null },
                    { 29, "BMW", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(536), "X1", null, null },
                    { 30, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(537), "C-Class", null, null },
                    { 31, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(538), "E-Class", null, null },
                    { 32, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(539), "S-Class", null, null },
                    { 33, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(541), "A-Class", null, null },
                    { 34, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(542), "CLA-Class", null, null },
                    { 35, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(543), "GLA-Class", null, null },
                    { 36, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(544), "GLC-Class", null, null },
                    { 37, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(545), "GLE-Class", null, null },
                    { 38, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(546), "GLS-Class", null, null },
                    { 39, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(547), "SLS AMG", null, null },
                    { 40, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(549), "AMG GT", null, null },
                    { 41, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(550), "G-Class", null, null },
                    { 42, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(551), "Maybach S-Class", null, null },
                    { 43, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(552), "EQC", null, null },
                    { 44, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(553), "EQS", null, null },
                    { 45, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(555), "Coupé", null, null },
                    { 46, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(556), "Roadster", null, null },
                    { 47, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(558), "B-Class", null, null },
                    { 48, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(559), "V-Class", null, null },
                    { 49, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(560), "GLB-Class", null, null },
                    { 50, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(561), "S-Class Coupe", null, null },
                    { 51, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(562), "SL-Class", null, null },
                    { 52, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(563), "M-Class", null, null },
                    { 53, "Mercedes-Benz", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(564), "X-Class", null, null },
                    { 54, "Audi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(565), "A4", null, null },
                    { 55, "Audi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(566), "A6", null, null },
                    { 56, "Audi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(568), "Q7", null, null },
                    { 57, "Audi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(569), "Q5", null, null },
                    { 58, "Audi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(570), "A8", null, null },
                    { 59, "Audi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(571), "Q3", null, null },
                    { 60, "Toyota", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(572), "Corolla", null, null },
                    { 61, "Toyota", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(573), "Camry", null, null },
                    { 62, "Toyota", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(574), "RAV4", null, null },
                    { 63, "Toyota", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(575), "Land Cruiser", null, null },
                    { 64, "Toyota", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(577), "Hilux", null, null },
                    { 65, "Kia", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(578), "Sorento", null, null },
                    { 66, "Kia", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(579), "Sportage", null, null },
                    { 67, "Kia", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(581), "K5", null, null },
                    { 68, "Kia", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(582), "Stinger", null, null },
                    { 69, "Hyundai", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(583), "Sonata", null, null },
                    { 70, "Hyundai", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(584), "Tucson", null, null },
                    { 71, "Hyundai", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(585), "Elantra", null, null },
                    { 72, "Hyundai", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(586), "Kona", null, null },
                    { 73, "Hyundai", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(587), "Palisade", null, null },
                    { 74, "Mitsubishi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(588), "Outlander", null, null },
                    { 75, "Mitsubishi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(589), "Lancer", null, null },
                    { 76, "Mitsubishi", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(591), "Eclipse", null, null },
                    { 77, "Lada", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(592), "Granta", null, null },
                    { 78, "Lada", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(594), "Vesta", null, null },
                    { 79, "Lada", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(595), "XRay", null, null },
                    { 80, "Volkswagen", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(596), "Golf", null, null },
                    { 81, "Volkswagen", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(597), "Passat", null, null },
                    { 82, "Volkswagen", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(598), "Tiguan", null, null },
                    { 83, "Volkswagen", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(599), "Jetta", null, null },
                    { 84, "Ford", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(601), "Mustang", null, null },
                    { 85, "Ford", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(645), "F-150", null, null },
                    { 86, "Land Rover", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(647), "Range Rover", null, null },
                    { 87, "Land Rover", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(648), "Discovery", null, null },
                    { 88, "Porsche", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(649), "911", null, null },
                    { 89, "Porsche", null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(650), "Cayenne", null, null }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2269), "Ağ", null, null },
                    { 2, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2274), "Qara", null, null },
                    { 3, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2275), "Qırmızı", null, null },
                    { 4, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2275), "Yaşıl", null, null },
                    { 5, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2276), "Mavi", null, null },
                    { 6, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2277), "Sarı", null, null },
                    { 7, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2278), "Narıncı", null, null },
                    { 8, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2278), "Bənövşəyi", null, null },
                    { 9, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2279), "Çəhrayı", null, null },
                    { 10, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2280), "Boz", null, null },
                    { 11, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2280), "Qəhvəyi", null, null },
                    { 12, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2281), "Göy", null, null },
                    { 13, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2282), "Tünd yaşıl", null, null },
                    { 14, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2283), "Açıq yaşıl", null, null },
                    { 15, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2283), "Tünd mavi", null, null },
                    { 16, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2284), "Açıq mavi", null, null },
                    { 17, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2285), "Tünd qəhvəyi", null, null },
                    { 18, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2285), "Açıq qəhvəyi", null, null },
                    { 19, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2286), "Bürünc", null, null },
                    { 20, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2287), "Gümüşü", null, null },
                    { 21, null, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(2287), "Qızılı", null, null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(163), "Master Employee", "Master", null, null });

            migrationBuilder.InsertData(
                table: "Filters",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(1682), "Yağ", null, null },
                    { 2, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(1684), "Hava", null, null },
                    { 3, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(1685), "Yanacaq", null, null },
                    { 4, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(1687), "Salon", null, null }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(3186), "Benzin", null, null },
                    { 2, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(3188), "Qaz", null, null },
                    { 3, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(3189), "Dizel", null, null },
                    { 4, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(3217), "Elektro", null, null },
                    { 5, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(3218), "Hybrid", null, null },
                    { 6, null, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(3219), "Plug-in Hybrid", null, null }
                });

            migrationBuilder.InsertData(
                table: "Motors",
                columns: new[] { "Id", "EngineCapacity", "InsertedBy", "InsertedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4741), null, null },
                    { 2, 200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4745), null, null },
                    { 3, 300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4746), null, null },
                    { 4, 400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4747), null, null },
                    { 5, 500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4748), null, null },
                    { 6, 600m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4750), null, null },
                    { 7, 700m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4751), null, null },
                    { 8, 800m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4752), null, null },
                    { 9, 900m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4753), null, null },
                    { 10, 1000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4755), null, null },
                    { 11, 1100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4755), null, null },
                    { 12, 1200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4756), null, null },
                    { 13, 1300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4757), null, null },
                    { 14, 1400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4758), null, null },
                    { 15, 1500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4759), null, null },
                    { 16, 1600m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4760), null, null },
                    { 17, 1700m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4760), null, null },
                    { 18, 1800m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4762), null, null },
                    { 19, 1900m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4763), null, null },
                    { 20, 2000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4764), null, null },
                    { 21, 2100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4765), null, null },
                    { 22, 2200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4765), null, null },
                    { 23, 2300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4766), null, null },
                    { 24, 2400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4767), null, null },
                    { 25, 2500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4768), null, null },
                    { 26, 2600m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4769), null, null },
                    { 27, 2700m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4770), null, null },
                    { 28, 2800m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4770), null, null },
                    { 29, 2900m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4771), null, null },
                    { 30, 3000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4772), null, null },
                    { 31, 3100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4773), null, null },
                    { 32, 3200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4774), null, null },
                    { 33, 3300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4775), null, null },
                    { 34, 3400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4776), null, null },
                    { 35, 3500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4777), null, null },
                    { 36, 3600m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4778), null, null },
                    { 37, 3700m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4779), null, null },
                    { 38, 3800m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4779), null, null },
                    { 39, 3900m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4780), null, null },
                    { 40, 4000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4781), null, null },
                    { 41, 4100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4782), null, null },
                    { 42, 4200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4783), null, null },
                    { 43, 4300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4784), null, null },
                    { 44, 4400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4785), null, null },
                    { 45, 4500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4785), null, null },
                    { 46, 4600m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4786), null, null },
                    { 47, 4700m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4787), null, null },
                    { 48, 4800m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4788), null, null },
                    { 49, 4900m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4789), null, null },
                    { 50, 5000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4790), null, null },
                    { 51, 5100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4791), null, null },
                    { 52, 5200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4791), null, null },
                    { 53, 5300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4792), null, null },
                    { 54, 5400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4793), null, null },
                    { 55, 5500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4794), null, null },
                    { 56, 5600m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4795), null, null },
                    { 57, 5700m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4796), null, null },
                    { 58, 5800m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4796), null, null },
                    { 59, 5900m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4797), null, null },
                    { 60, 6000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4798), null, null },
                    { 61, 6100m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4799), null, null },
                    { 62, 6200m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4800), null, null },
                    { 63, 6300m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4801), null, null },
                    { 64, 6400m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4801), null, null },
                    { 65, 6500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4802), null, null },
                    { 66, 6500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4824), null, null },
                    { 67, 7000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4825), null, null },
                    { 68, 7500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4826), null, null },
                    { 69, 8000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4827), null, null },
                    { 70, 8500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4828), null, null },
                    { 71, 9000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4828), null, null },
                    { 72, 9500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4829), null, null },
                    { 73, 10000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4830), null, null },
                    { 74, 10500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4831), null, null },
                    { 75, 11000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4832), null, null },
                    { 76, 11500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4833), null, null },
                    { 77, 12000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4834), null, null },
                    { 78, 12500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4835), null, null },
                    { 79, 13000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4835), null, null },
                    { 80, 13500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4836), null, null },
                    { 81, 14000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4837), null, null },
                    { 82, 14500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4838), null, null },
                    { 83, 15000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4839), null, null },
                    { 84, 15500m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4840), null, null },
                    { 85, 16000m, 3, new DateTime(2024, 12, 18, 23, 8, 2, 629, DateTimeKind.Local).AddTicks(4840), null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, null, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(4484), false, "Elf", null, null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsDeleted", "RoleName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(5967), false, "Costumer", null, null },
                    { 2, null, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(6011), false, "Branch", null, null }
                });

            migrationBuilder.InsertData(
                table: "SAEViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(7158), false, null, null },
                    { 2, 5, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(7160), false, null, null },
                    { 3, 10, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(7162), false, null, null },
                    { 4, 20, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(7164), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8701), "Sürətlər qutusu yağ dəyişmə", null, null },
                    { 2, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8703), "Mühərrik yağ dəyişmə", null, null },
                    { 3, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8705), "Antifiriz dəyişmə", null, null },
                    { 4, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8707), "Əyləc mayesi dəyişmə", null, null },
                    { 5, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8708), "Arxa körpü", null, null },
                    { 6, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8710), "Ön körpü", null, null },
                    { 7, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(8711), "Diferensial (Razdatka)", null, null }
                });

            migrationBuilder.InsertData(
                table: "WinterViscosities",
                columns: new[] { "Id", "Grade", "InsertedBy", "InsertedDate", "IsDeleted", "ServiceType", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 8m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3579), false, 1, null, null },
                    { 2, 12m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3581), false, 1, null, null },
                    { 3, 16m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3583), false, 1, null, null },
                    { 4, 20m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3585), false, 1, null, null },
                    { 5, 30m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3587), false, 1, null, null },
                    { 6, 40m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3588), false, 1, null, null },
                    { 7, 50m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3590), false, 1, null, null },
                    { 8, 60m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3591), false, 1, null, null },
                    { 9, 3m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3593), false, 2, null, null },
                    { 10, 4m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3594), false, 2, null, null },
                    { 11, 5.1m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3596), false, 2, null, null },
                    { 12, 6m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3598), false, 2, null, null },
                    { 13, 5m, 1, new DateTime(2024, 12, 18, 23, 8, 2, 635, DateTimeKind.Local).AddTicks(3599), false, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "InsertedBy", "InsertedDate", "IsOtp", "Name", "Password", "Phone", "RefreshToken", "RefreshTokenExpiryTime", "RoleId", "Surname", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, 1, new DateTime(2024, 12, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(8570), false, "Master Admin", "$2a$11$gZdTV78QAwiPRpd8n11MLe8p111KlStD/xo1/1qUXUBifJnwZuj8K", "+994000", "qOLhGm3T0r6938al5PjO2nyYbnLajCGQP/XU6CJkcZ4=", new DateTime(2025, 2, 18, 23, 8, 2, 628, DateTimeKind.Local).AddTicks(8551), 2, "Master", null, null });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "BranchId", "InsertedBy", "InsertedDate", "IsDeleted", "Phone", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3097), false, "+994703305788", null, null },
                    { 2, 2, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3100), false, "+994702343134", null, null },
                    { 3, 2, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3101), false, "+994706843434", null, null },
                    { 4, 4, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3103), false, "+994777332322", null, null },
                    { 5, 4, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3104), false, "+994706743434", null, null },
                    { 6, 3, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3106), false, "+994707552322", null, null },
                    { 7, 3, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3107), false, "+994702153434", null, null },
                    { 8, 3, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3108), false, "+994702344334", null, null },
                    { 9, 3, 1, new DateTime(2024, 12, 18, 23, 8, 2, 633, DateTimeKind.Local).AddTicks(3110), false, "+994702344334", null, null }
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
