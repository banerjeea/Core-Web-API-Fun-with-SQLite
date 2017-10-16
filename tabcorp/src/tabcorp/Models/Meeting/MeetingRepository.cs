using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tabcorp.Models.Meeting
{
    public class MeetingRepository : DbContext, IMeetingRepository
    {
        private const string DataAddedSuccessfully = "Data Added";
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
            try
            {
                Meetings.Add(meeting.meeting);

                SaveChanges();

                return DataAddedSuccessfully;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
