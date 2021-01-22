using Microsoft.EntityFrameworkCore.Migrations;

namespace APIParks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nationals",
                columns: new[] { "NationalId", "NationalParkDescription", "NationalParkLocation", "NationalParkName" },
                values: new object[,]
                {
                    { 1, "Yellowstone National Park features dramatic canyons, alpine rivers, lush forests, hot springs, and gushing geysers, including its most famous, Old Faithful. Yellowstone Lake is one of the largest high-elevation lakes in North America and is centered over the Yellowstone Caldera, the largest super-volcano on the continent.", "Wyoming, Montana, Idaho", "Yellowstone National Park" },
                    { 2, "Grand Teton National Park features the major peaks of the 40-mile long Teton Range, as well as most of the northern sections of the valley known as Jackson Hole. The park is named for Grand Teton, the tallest mountain in the Teton Range.", "Wyoming", "Grand Teton National Park" },
                    { 3, "Haleakala National Park is named after Haleakala, a dormant volcano within its boundaries. The name is Hawaiian for 'house of the sun'. According to a local legend, the demigod Maui imprisoned the sun here in order to lengthen the day.", "Maui, Hawaii", "Haleakala National Park" },
                    { 4, "Mount Rainier National Park features Mount Rainier, also known as Tahoma or Tacoma, a large active stratovolcano in the Cascade Range of the Pacific Northwest. The highest point in the Cascade Range, Mount Rainier is surrounded by valleys, waterfalls, subalpine meadows, and 91,000 acres of old-growth forest. More than 25 glaciers descend the flanks of the volcano. Carbon Glacier is the largest glacier by volume in the contiguous United States, while Emmons Glacier is the largest glacier by area.", "Washington", "Mount Rainier National Park" },
                    { 5, "Crater Lake Nation Park encompasses the caldera of Crater Lake, a remnant of Mount Mazama, a destroyed volcano, and the surrounding hills and forests. Carter lake is the deepest lake in the United States, second-deepest in North America and the ninth deepest in the world. It has no streams flowing into or out of it. All water that enters the lake is eventually last from evaporation or subsurface seepage. The lake's water commonly has a striking blue hue, and the lake is refilled entirely from direct precipitation in the form of snow and rain.", "Oregon", "Crater Lake National Park" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "StateParkDescription", "StateParkLocation", "StateParkName" },
                values: new object[,]
                {
                    { 1, "Iao Valley State Park features a dense rainforest canopy. It is dominated by the Iao Needle, a 1,200ft vegetation-covered lava remnant that rises from the valley floor to a higher height than the Eiffel Tower. ", "Maui, Hawaii", "Iao Valley State Park" },
                    { 2, "Eldorado Canyon State Park consists of two areas, the Inner Canyon and Crescent Meadows. It is home to one of the world's most accessible and comprehensive rock climbing areas.", "Colorado", "Eldorado Canyon State Park" },
                    { 3, "Niagara Falls State Park is recognized at the oldest state park in the United States. It contains the American Falls, the Bridal Veil Falls, and a portion of the Horseshoe Falls (also known as the Canadian Falls).", "New York", "Niagara Falls State Park" },
                    { 4, "Na Pali Coast State Park is located on the oldest inhabited Hawaiian Island, Kaua'i.It is known for its towering pali, or sea cliffs, narrow valleys, streams and cascading waterfalls. The state park was formed to protect the Kalalau Valley. ", "Kaua'i, Hawaii", "Na Pali Coast State Park" },
                    { 5, "Palouse Falls State Park is named for the 200ft Palouse Falls, formerly known as Aput Aput, meaning 'Falling Water', so named by the Palouse Indians on the Palouse River. ", "Washington", "Palouse Falls State Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nationals",
                keyColumn: "NationalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5);
        }
    }
}
