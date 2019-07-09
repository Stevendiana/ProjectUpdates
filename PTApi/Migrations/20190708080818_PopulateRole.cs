using Microsoft.EntityFrameworkCore.Migrations;

namespace PTApi.Migrations
{
    public partial class PopulateRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AprAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "AprResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "AugAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "AugResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DecAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "DecResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "FebAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "FebResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "JanAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "JanResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "JulAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "JulResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "JunAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "JunResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "MarAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "MarResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "MayAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "MayResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "NovAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "NovResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "OctAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "OctResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "SepAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "SepResourceUtilizationInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "TotalAvailabilityBeforeHolidaysInDays",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "TotalUtilizationInDays",
                table: "Resources");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "ForecastTasks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AprAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AprResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AugAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AugResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DecAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DecResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FebResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JanAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JanResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JulAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JulResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JunAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JunResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MarAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MarResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MayAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MayResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NovAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NovResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OctAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OctResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SepAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SepResourceUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAvailabilityBeforeHolidaysInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalUtilizationInDays",
                table: "Resources",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "ForecastTasks",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
