using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tabcorp.Models.Meeting;

namespace tabcorp.Repository.Meeting
{
    public class MeetingRepository : DbContext, IMeetingRepository
    {
        private const string DataAddedSuccessfully = "Data Added";
        public MeetingRepository(DbContextOptions<MeetingRepository> options)
            : base(options)
        { }

        public DbSet<Models.Meeting.Meeting> Meetings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Models.Meeting.Meeting>().HasKey(k => k.Id);

        }

        public async Task<bool> AddMeetings(RootMeeting meeting)
        {
            try
            {
                Meetings.Add(meeting.meeting);

               var count =  await SaveChangesAsync();

                if (count > 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }
    }
}
