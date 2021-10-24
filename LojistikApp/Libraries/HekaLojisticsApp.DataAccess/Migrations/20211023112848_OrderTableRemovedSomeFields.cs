using Microsoft.EntityFrameworkCore.Migrations;

namespace HekaLojisticsApp.DataAccess.Migrations
{
    public partial class OrderTableRemovedSomeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerCustomerAddress1",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerAddress2",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerCityId",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerCountryId",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerDistrictId",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerFax",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerNumber",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerTaxNumber",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerTaxOffice",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerTitle1",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerCustomerTitle2",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BuyerRepresentative",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CurrencyKod",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerAddress1",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerAddress2",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerCityId",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerCountryId",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerDistrictId",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerFax",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerNumber",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentative",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerTaxNumber",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerTaxOffice",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerTitle1",
                schema: "Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerTitle2",
                schema: "Order",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "ExitCustomsCode",
                schema: "Order",
                table: "Order",
                type: "int",
                maxLength: 12,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntryCustomsCode",
                schema: "Order",
                table: "Order",
                type: "int",
                maxLength: 12,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExitCustomsCode",
                schema: "Order",
                table: "Order",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "EntryCustomsCode",
                schema: "Order",
                table: "Order",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 12);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerAddress1",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerAddress2",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerCityId",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerCountryId",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerDistrictId",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuyerCustomerFax",
                schema: "Order",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuyerCustomerNumber",
                schema: "Order",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuyerCustomerTaxNumber",
                schema: "Order",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuyerCustomerTaxOffice",
                schema: "Order",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerTitle1",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerCustomerTitle2",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BuyerRepresentative",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyKod",
                schema: "Order",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress1",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress2",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCityId",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCountryId",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerDistrictId",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerFax",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerNumber",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerRepresentative",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerTaxNumber",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerTaxOffice",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerTitle1",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerTitle2",
                schema: "Order",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
