using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentMicroservice.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfrimDateOfVaccination",
                table: "Vaccinations");

            migrationBuilder.DropColumn(
                name: "Confrimdate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Doctortype",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Problemdescription",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserMail",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Counseledbefore",
                table: "Appointments",
                newName: "CounseledBefore");

            migrationBuilder.AlterColumn<string>(
                name: "UserMail",
                table: "Vaccinations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdProof",
                table: "Vaccinations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChooseSlot",
                table: "Vaccinations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfVaccination",
                table: "Vaccinations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Vaccinations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CounseledBefore",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppointmentDate",
                table: "Appointments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Appointments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slot",
                table: "Appointments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Appointments",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfVaccination",
                table: "Vaccinations");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Vaccinations");

            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Slot",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "CounseledBefore",
                table: "Appointments",
                newName: "Counseledbefore");

            migrationBuilder.AlterColumn<string>(
                name: "UserMail",
                table: "Vaccinations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IdProof",
                table: "Vaccinations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ChooseSlot",
                table: "Vaccinations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ConfrimDateOfVaccination",
                table: "Vaccinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Counseledbefore",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Confrimdate",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Doctortype",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Problemdescription",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserMail",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
