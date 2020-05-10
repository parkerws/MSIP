using Microsoft.EntityFrameworkCore.Migrations;

namespace MSIP_App.Migrations
{
    public partial class UrlsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Calendars_CalendarId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Calendars_CalendarId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CalendarId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Events_CalendarId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CalendarId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CalendarId",
                table: "Events");

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Url = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urls");

            migrationBuilder.AddColumn<long>(
                name: "CalendarId",
                table: "Tasks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CalendarId",
                table: "Events",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CalendarId",
                table: "Tasks",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CalendarId",
                table: "Events",
                column: "CalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Calendars_CalendarId",
                table: "Events",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Calendars_CalendarId",
                table: "Tasks",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
