using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tabcorp.Models.Meeting;
using tabcorp.Repository.Meeting;

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
            if (input == null || !ModelState.IsValid) return BadRequest();
            try
            {
                if (await MeetingRepository.AddMeetings(input)) 
                    return Json("Data successfully added");
                return StatusCode(500);
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
