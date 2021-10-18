using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HekaLojisticsApp.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Vehicle");

            migrationBuilder.CreateTable(
                name: "Care",
                schema: "Vehicle",
                columns: table => new
                {
                    VehicleCareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePlate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehiceCareTypeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OperationCompanyId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CareDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    KmHour = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    PersonnelId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    CurrencyCode = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Care", x => x.VehicleCareId);
                });

            migrationBuilder.CreateTable(
                name: "CareType",
                schema: "Vehicle",
                columns: table => new
                {
                    VehicleCareTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    DefaultPeriyodUnitCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Compulsory = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareType", x => x.VehicleCareTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                schema: "Vehicle",
                columns: table => new
                {
                    VehicleInsuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicePlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InsuranceTypeCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    OperationCompanyId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KmHour = table.Column<int>(type: "int", nullable: false),
                    PersonnelId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.VehicleInsuranceId);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceType",
                schema: "Vehicle",
                columns: table => new
                {
                    VehicleInsuranceTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    DefaultPeriyodUnitCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Compulsory = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceType", x => x.VehicleInsuranceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                schema: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ChassisNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    VehicleAllocationCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    VehicleTypeCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    OwnerCompanyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    KmHour = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrailerHeadWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadCapacity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrailerTypeCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    StatusCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    CarePeriyot = table.Column<int>(type: "int", nullable: false),
                    ProportionalLimit = table.Column<int>(type: "int", nullable: false),
                    CareNotification = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TireNotification = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Approval = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Invalidation = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    KmHourControl = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                schema: "Vehicle",
                columns: table => new
                {
                    VehicleNotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicePlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CareStep = table.Column<int>(type: "int", nullable: false),
                    MailNotification = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SmsNotification = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ExtraNotification = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.VehicleNotificationId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeadlineDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadTypeCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    TransactionDirectionCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    StatusCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    UploadPointCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ShipperCompanyId = table.Column<int>(type: "int", nullable: false),
                    BuyerCompanyId = table.Column<int>(type: "int", nullable: false),
                    TotalWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeightUnitCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    VolumeUnitCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Closed = table.Column<bool>(type: "bit", nullable: false),
                    Approval = table.Column<bool>(type: "bit", nullable: false),
                    Cancel = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceStatusCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    ExitCustomsCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    EntryCustomsCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CustomerRepresentative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerDistrictId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCountryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerRepresentative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerDistrictId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerCityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerCountryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCustomerTaxOffice = table.Column<int>(type: "int", nullable: false),
                    BuyerCustomerTaxNumber = table.Column<int>(type: "int", nullable: false),
                    BuyerCustomerNumber = table.Column<int>(type: "int", nullable: false),
                    BuyerCustomerFax = table.Column<int>(type: "int", nullable: false),
                    CurrencyKod = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    RateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Tire",
                schema: "Vehicle",
                columns: table => new
                {
                    VehiceTireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mark = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    VehiceTireTypeCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DirectionTypeCode = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    DimensionsInfo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    MontageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperationCompanyId = table.Column<int>(type: "int", nullable: false),
                    PersonnelId = table.Column<int>(type: "int", nullable: false),
                    KmHour = table.Column<int>(type: "int", nullable: false),
                    KmHourLimit = table.Column<int>(type: "int", nullable: false),
                    KmHourControl = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Invalidation = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CurrencyCode = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tire", x => x.VehiceTireId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Care",
                schema: "Vehicle");

            migrationBuilder.DropTable(
                name: "CareType",
                schema: "Vehicle");

            migrationBuilder.DropTable(
                name: "Insurance",
                schema: "Vehicle");

            migrationBuilder.DropTable(
                name: "InsuranceType",
                schema: "Vehicle");

            migrationBuilder.DropTable(
                name: "Main",
                schema: "Vehicle");

            migrationBuilder.DropTable(
                name: "Notification",
                schema: "Vehicle");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Tire",
                schema: "Vehicle");
        }
    }
}
