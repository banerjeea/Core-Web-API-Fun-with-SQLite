using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabcorp.Models.Meeting
{
    public class Meetings
    {
        public Meeting meeting { get; set; }
    }
    public class Meeting
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string date { get; set; }
        public List<Race> races { get; set; }
    }

    public class Race
    {
        public int id { get; set; }
        public int racenumber { get; set; }
        public string racename { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
    }


 }
