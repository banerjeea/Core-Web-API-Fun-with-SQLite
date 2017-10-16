using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabcorp.Models.Meeting
{
    public interface IMeetingRepository
    {
        string AddMeetings(RootMeeting meeting);
    }
}
