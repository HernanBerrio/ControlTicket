using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlTicket.Migrations
{
    public partial class EntraceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntraceId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntranceId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Entrace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entrance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrance", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EntraceId",
                table: "Tickets",
                column: "EntraceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EntranceId",
                table: "Tickets",
                column: "EntranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrace_Id",
                table: "Entrace",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrace_EntraceId",
                table: "Tickets",
                column: "EntraceId",
                principalTable: "Entrace",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Entrance_EntranceId",
                table: "Tickets",
                column: "EntranceId",
                principalTable: "Entrance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrace_EntraceId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Entrance_EntranceId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Entrace");

            migrationBuilder.DropTable(
                name: "Entrance");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EntraceId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EntranceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EntraceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EntranceId",
                table: "Tickets");
        }
    }
}
