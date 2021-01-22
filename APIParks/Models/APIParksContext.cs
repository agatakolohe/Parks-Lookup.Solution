using Microsoft.EntityFrameworkCore;

namespace APIParks.Models
{
    public class APIParksContext : DbContext
    {
        public APIParksContext(DbContextOptions<APIParksContext> options)
            : base(options)
        {
        }

        public DbSet<State> States { get; set; }
        public DbSet<National> Nationals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<National>()
                .HasData(
                    new National
                    {
                        NationalId = 1,
                        NationalParkName = "Yellowstone National Park",
                        NationalParkLocation = "Wyoming",
                        NationalParkDescription = "Yellowstone National Park features dramatic canyons, alpine rivers, lush forests, hot springs, and gushing geysers, including its most famous, Old Faithful. Yellowstone Lake is one of the largest high-elevation lakes in North America and is centered over the Yellowstone Caldera, the largest super-volcano on the continent."
                    },
                    new National
                    {
                        NationalId = 2,
                        NationalParkName = "Grand Teton National Park",
                        NationalParkLocation = "Wyoming",
                        NationalParkDescription = "Grand Teton National Park features the major peaks of the 40-mile long Teton Range, as well as most of the northern sections of the valley known as Jackson Hole. The park is named for Grand Teton, the tallest mountain in the Teton Range."
                    },
                    new National
                    {
                        NationalId = 3,
                        NationalParkName = "Haleakala National Park",
                        NationalParkLocation = "Hawaii",
                        NationalParkDescription = "Haleakala National Park is named after Haleakala, a dormant volcano within its boundaries. The name is Hawaiian for 'house of the sun'. According to a local legend, the demigod Maui imprisoned the sun here in order to lengthen the day."
                    },
                    new National
                    {
                        NationalId = 4,
                        NationalParkName = "Mount Rainier National Park",
                        NationalParkLocation = "Washington",
                        NationalParkDescription = "Mount Rainier National Park features Mount Rainier, also known as Tahoma or Tacoma, a large active stratovolcano in the Cascade Range of the Pacific Northwest. The highest point in the Cascade Range, Mount Rainier is surrounded by valleys, waterfalls, subalpine meadows, and 91,000 acres of old-growth forest. More than 25 glaciers descend the flanks of the volcano. Carbon Glacier is the largest glacier by volume in the contiguous United States, while Emmons Glacier is the largest glacier by area."
                    },
                    new National
                    {
                        NationalId = 5,
                        NationalParkName = "Crater Lake National Park",
                        NationalParkLocation = "Oregon",
                        NationalParkDescription = "Crater Lake Nation Park encompasses the caldera of Crater Lake, a remnant of Mount Mazama, a destroyed volcano, and the surrounding hills and forests. Carter lake is the deepest lake in the United States, second-deepest in North America and the ninth deepest in the world. It has no streams flowing into or out of it. All water that enters the lake is eventually last from evaporation or subsurface seepage. The lake's water commonly has a striking blue hue, and the lake is refilled entirely from direct precipitation in the form of snow and rain."
                    }
                );
            builder.Entity<State>()
                .HasData(
                    new State
                    {
                        StateId = 1,
                        StateParkName = "Iao Valley State Park",
                        StateParkLocation = "Hawaii",
                        StateParkDescription = "Iao Valley State Park features a dense rainforest canopy. It is dominated by the Iao Needle, a 1,200ft vegetation-covered lava remnant that rises from the valley floor to a higher height than the Eiffel Tower. "
                    },
                    new State
                    {
                        StateId = 2,
                        StateParkName = "Eldorado Canyon State Park",
                        StateParkLocation = "Colorado",
                        StateParkDescription = "Eldorado Canyon State Park consists of two areas, the Inner Canyon and Crescent Meadows. It is home to one of the world's most accessible and comprehensive rock climbing areas."
                    },
                    new State
                    {
                        StateId = 3,
                        StateParkName = "Niagara Falls State Park",
                        StateParkLocation = "New York",
                        StateParkDescription = "Niagara Falls State Park is recognized at the oldest state park in the United States. It contains the American Falls, the Bridal Veil Falls, and a portion of the Horseshoe Falls (also known as the Canadian Falls)."
                    },
                    new State
                    {
                        StateId = 4,
                        StateParkName = "Na Pali Coast State Park",
                        StateParkLocation = "Hawaii",
                        StateParkDescription = "Na Pali Coast State Park is located on the oldest inhabited Hawaiian Island, Kaua'i. It is known for its towering pali, or sea cliffs, narrow valleys, streams and cascading waterfalls. The state park was formed to protect the Kalalau Valley. "
                    },
                    new State
                    {
                        StateId = 5,
                        StateParkName = "Palouse Falls State Park",
                        StateParkLocation = "Washington",
                        StateParkDescription = "Palouse Falls State Park is named for the 200ft Palouse Falls, formerly known as Aput Aput, meaning 'Falling Water', so named by the Palouse Indians on the Palouse River. "
                    }
                );
        }
    }
}