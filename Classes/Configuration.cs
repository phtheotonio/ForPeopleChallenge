using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPeopleChallenge.Classes
{
    public class Configuration
    {
        public int id { get; set; }
        public object launch_library_id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string full_name { get; set; }
        public string variant { get; set; }
    }
}
