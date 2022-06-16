using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Ticket_Booking_System.Migrations.ApplicationDb
{
    public partial class AddVehiclestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VechilesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCID = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VechilesID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
