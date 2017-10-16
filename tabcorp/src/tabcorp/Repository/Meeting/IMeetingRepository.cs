using System.Threading.Tasks;
using tabcorp.Models.Meeting;

namespace tabcorp.Repository.Meeting
{
    public interface IMeetingRepository
    {
        Task<bool> AddMeetings(RootMeeting meeting);
    }
}
