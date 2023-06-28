using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPeopleChallenge.Classes
{
    public class Location
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
        public string map_image { get; set; }
        public int total_launch_count { get; set; }
        public int total_landing_count { get; set; }
    }
}
