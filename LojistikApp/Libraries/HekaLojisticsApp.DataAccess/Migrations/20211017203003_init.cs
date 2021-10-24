using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HekaLojisticsApp.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Order");

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "Order",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order",
                schema: "Order");
        }
    }
}
