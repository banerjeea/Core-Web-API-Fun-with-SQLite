using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace tabcorp.Models.Meeting
{
    public class Meetings
    {
        public Meeting meeting { get; set; }
    }
    public class Meeting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Date { get; set; }
        public List<Race> Races { get; set; }
    }

    public class Race
    {
        public int Id { get; set; }
        public int Racenumber { get; set; }
        public string Racename { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
    }


 }
