using Microsoft.EntityFrameworkCore.Migrations;

namespace MSIP_App.Migrations
{
    public partial class SeedDataAttempt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Urls",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Embry-Riddle", "https://fed.erau.edu/oamfed/idp/wsfed11?wa=wsignin1.0&wtrealm=urn%3amyernie%3asharepoint&wctx=https%3a%2f%2fernie.erau.edu%2f_layouts%2f15%2fAuthenticate.aspx%3fSource%3d%252F" },
                    { 2, "Microsoft Military Education Portal", "https://miledu.microsoft.com/login?next=/mssainfo" },
                    { 3, "Skillpipe", "https://www.skillpipe.com/#/account/login" },
                    { 4, "Microsoft Azure Portal", "https://portal.azure.com/" },
                    { 5, "Learn On Demand", "https://mssa-erau.learnondemand.net/User/Login?ReturnUrl=%2fUser%2fCurrentTraining%2f1395478" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
