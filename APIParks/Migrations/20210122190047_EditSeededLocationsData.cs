using Microsoft.EntityFrameworkCore.Migrations;

namespace APIParks.Migrations
{
    public partial class EditSeededLocationsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 3,
                column: "NationalParkLocation",
                value: "Hawaii");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "StateParkLocation",
                value: "Hawaii");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4,
                columns: new[] { "StateParkDescription", "StateParkLocation" },
                values: new object[] { "Na Pali Coast State Park is located on the oldest inhabited Hawaiian Island, Kaua'i. It is known for its towering pali, or sea cliffs, narrow valleys, streams and cascading waterfalls. The state park was formed to protect the Kalalau Valley. ", "Hawaii" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 3,
                column: "NationalParkLocation",
                value: "Maui, Hawaii");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "StateParkLocation",
                value: "Maui, Hawaii");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4,
                columns: new[] { "StateParkDescription", "StateParkLocation" },
                values: new object[] { "Na Pali Coast State Park is located on the oldest inhabited Hawaiian Island, Kaua'i.It is known for its towering pali, or sea cliffs, narrow valleys, streams and cascading waterfalls. The state park was formed to protect the Kalalau Valley. ", "Kaua'i, Hawaii" });
        }
    }
}
