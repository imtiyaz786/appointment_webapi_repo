using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentMicroservice.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Confrimdate = table.Column<string>(nullable: false),
                    Doctortype = table.Column<string>(nullable: false),
                    Problemdescription = table.Column<string>(nullable: true),
                    Counseledbefore = table.Column<string>(nullable: true),
                    UserMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
