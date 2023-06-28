using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPeopleChallenge.Classes
{
    public class Pad
    {
        public int id { get; set; }
        public string url { get; set; }
        public int? agency_id { get; set; }
        public string name { get; set; }
        public object info_url { get; set; }
        public string wiki_url { get; set; }
        public string map_url { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Location location { get; set; }
        public string map_image { get; set; }
        public int total_launch_count { get; set; }
    }
}
