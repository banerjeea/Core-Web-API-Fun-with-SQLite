using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
       
        [HttpPost("Meetings")]
        public async Task<IActionResult> Meetings([FromBody] RootMeeting input)
        {
            if (input == null) return BadRequest();
            try
            {
                await MeetingRepository.AddMeetings(input);
                return Ok();

            }

            catch (HttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("Health")]
        public HttpResponseMessage Health()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
      
    }
}
