using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tabcorp.Models.Meeting;

namespace tabcorp.Controllers
{
    [Route("api")]
    public class MeetingController : Controller
    {
        public IMeetingRepository MeetingRepository;

        public MeetingController(IMeetingRepository meetingRepository)
        {
            MeetingRepository = meetingRepository;
        }
       
        // POST api/values
        [HttpPost("Meetings")]
        public void Meetings([FromBody] Meetings input)
        {
            var test = input;
            MeetingRepository.AddMeetings(input);
        }

        [HttpGet("Health")]
        public HttpResponseMessage Health()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
      
    }
}
