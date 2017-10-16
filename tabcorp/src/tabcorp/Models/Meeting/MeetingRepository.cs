using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tabcorp.Models.Meeting
{
    public class MeetingRepository : DbContext, IMeetingRepository
    {
        public MeetingRepository(DbContextOptions<MeetingRepository> options)
            : base(options)
        { }

        public DbSet<Meetings> Meetings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Meetings>().HasKey(k => k.meeting.Id);

        }

        public string AddMeetings(Meetings meeting)
        {
            Meetings.Add(new Meetings
            {
                meeting = meeting.meeting
            });

          var count =  SaveChanges();
          return count.ToString();
        }
    }
}
