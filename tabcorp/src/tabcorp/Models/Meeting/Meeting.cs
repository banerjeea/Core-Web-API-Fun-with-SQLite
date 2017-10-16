using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace tabcorp.Models.Meeting
{
    public class RootMeeting
    {
        public Meeting meeting { get; set; }
    }
    public class Meeting
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        public List<Race> Races { get; set; }
    }

    public class Race
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int Racenumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Racename { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Starttime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Endtime { get; set; }
    }

}
