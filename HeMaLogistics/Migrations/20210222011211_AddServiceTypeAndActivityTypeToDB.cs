using Microsoft.EntityFrameworkCore.Migrations;

namespace HeMaLogistics.Migrations
{
    public partial class AddServiceTypeAndActivityTypeToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_ActivityType_ServiceType_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityType_ServiceId",
                table: "ActivityType",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityType");

            migrationBuilder.DropTable(
                name: "ServiceType");
        }
    }
}
