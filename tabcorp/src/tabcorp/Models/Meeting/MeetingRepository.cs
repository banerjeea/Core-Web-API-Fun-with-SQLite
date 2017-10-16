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

        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Meeting>().HasKey(k => k.Id);

        }

        public string AddMeetings(RootMeeting meeting)
        {
            Meetings.Add(meeting.meeting);

          var count =  SaveChanges();
          return count.ToString();
        }
    }
}
