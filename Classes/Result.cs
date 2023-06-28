using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPeopleChallenge.Classes
{
    public class Result
    {
        public string id { get; set; }
        public string url { get; set; }
        public object launch_library_id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public Status status { get; set; }
        public DateTime net { get; set; }
        public DateTime window_end { get; set; }
        public DateTime window_start { get; set; }
        public bool inhold { get; set; }
        public bool tbdtime { get; set; }
        public bool tbddate { get; set; }
        public object probability { get; set; }
        public object holdreason { get; set; }
        public object failreason { get; set; }
        public object hashtag { get; set; }
        public LaunchServiceProvider launch_service_provider { get; set; }
        public Rocket rocket { get; set; }
        public Mission mission { get; set; }
        public Pad pad { get; set; }
        public bool webcast_live { get; set; }
        public string image { get; set; }
        public object infographic { get; set; }
        public List<object> program { get; set; }
    }
}
