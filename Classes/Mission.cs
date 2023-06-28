using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPeopleChallenge.Classes
{
    public class Mission
    {
        public int id { get; set; }
        public object launch_library_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object launch_designator { get; set; }
        public string type { get; set; }
        public Orbit orbit { get; set; }
    }
}
