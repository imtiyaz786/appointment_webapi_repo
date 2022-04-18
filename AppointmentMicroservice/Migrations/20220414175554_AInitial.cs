using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentMicroservice.Migrations
{
    public partial class AInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccinations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfrimDateOfVaccination = table.Column<string>(nullable: false),
                    VaccineName = table.Column<string>(nullable: false),
                    ChooseSlot = table.Column<string>(nullable: true),
                    IdProof = table.Column<string>(nullable: true),
                    UserMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccinations");
        }
    }
}
