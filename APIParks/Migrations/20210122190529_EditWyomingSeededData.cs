using Microsoft.EntityFrameworkCore.Migrations;

namespace APIParks.Migrations
{
    public partial class EditWyomingSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 1,
                column: "NationalParkLocation",
                value: "Wyoming");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 1,
                column: "NationalParkLocation",
                value: "Wyoming, Montana, Idaho");
        }
    }
}
