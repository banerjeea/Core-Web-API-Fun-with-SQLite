using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using tabcorp.Controllers;
using tabcorp.Models.Meeting;
using tabcorp.Repository.Meeting;
using Xunit;

namespace tabcorp.test
{
    public class TestMeetingController
    {
        private readonly MeetingController _meetingController;
        private readonly Mock<IMeetingRepository> _meetingRepository;

        public TestMeetingController()
        {
            _meetingRepository = new Mock<IMeetingRepository>();
            _meetingController = new MeetingController(_meetingRepository.Object);
        }

        [Fact]
        public async void TestMeetingControllerWithGoodRequest()
        {
            //Arrange
            var race = new List<Race>
            {
                new Race
                {
                    Id = 9001001,
                    Racenumber = 1,
                    Racename = "first",
                    Starttime = DateTime.UtcNow,
                    Endtime = DateTime.UtcNow.AddHours(3)
                },
                new Race
                {
                    Id = 9001002,
                    Racenumber = 2,
                    Racename = "second",
                    Starttime = DateTime.UtcNow,
                    Endtime = DateTime.UtcNow.AddHours(4)
                }
            };
            var rootmeeting = new RootMeeting
            {
                meeting = new Meeting
                {
                    Date = DateTime.UtcNow,
                    Id = 9001,
                    Name = "First Meeting",
                    Races = race

                }
            };


             _meetingRepository.Setup(p => p.AddMeetings(rootmeeting)).ReturnsAsync(true);

            //Act
            var result = await _meetingController.Meetings(new RootMeeting {meeting = rootmeeting.meeting}) as OkResult;

             //TODO:Fix required
            //Assert
           // Assert.NotNull(result);
          // if (result.StatusCode != null) Assert.Equal(result.StatusCode.Value, 200);
        }

    }
}
