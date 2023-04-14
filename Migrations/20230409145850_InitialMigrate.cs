using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightTour_Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    proposalId = table.Column<string>(type: "TEXT", nullable: true),
                    origin = table.Column<string>(type: "TEXT", nullable: true),
                    destination = table.Column<string>(type: "TEXT", nullable: true),
                    airlineCode = table.Column<string>(type: "TEXT", nullable: true),
                    flightNumber = table.Column<string>(type: "TEXT", nullable: true),
                    leaveDateTime = table.Column<string>(type: "TEXT", nullable: true),
                    arrivalDateTime = table.Column<string>(type: "TEXT", nullable: true),
                    aircraft = table.Column<string>(type: "TEXT", nullable: true),
                    priceChild = table.Column<int>(type: "INTEGER", nullable: true),
                    priceAdult = table.Column<int>(type: "INTEGER", nullable: true),
                    priceInfant = table.Column<int>(type: "INTEGER", nullable: true),
                    flightId = table.Column<string>(type: "TEXT", nullable: true),
                    classType = table.Column<string>(type: "TEXT", nullable: true),
                    classTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    statusName = table.Column<string>(type: "TEXT", nullable: true),
                    ticketType = table.Column<string>(type: "TEXT", nullable: true),
                    seat = table.Column<int>(type: "INTEGER", nullable: true),
                    stars = table.Column<int>(type: "INTEGER", nullable: true),
                    uniqueKey = table.Column<string>(type: "TEXT", nullable: true),
                    terminal = table.Column<string>(type: "TEXT", nullable: true),
                    ticketTypeLabel = table.Column<string>(type: "TEXT", nullable: true),
                    originName = table.Column<string>(type: "TEXT", nullable: true),
                    destinationName = table.Column<string>(type: "TEXT", nullable: true),
                    airlineName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightData");
        }
    }
}
