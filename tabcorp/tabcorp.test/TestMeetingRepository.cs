﻿using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using tabcorp.Models.Meeting;
using tabcorp.Repository.Meeting;
using Xunit;
using Xunit.Sdk;

namespace tabcorp.test
{
    public class TestMeetingRepository
    {
        private readonly SqliteConnection _connection = new SqliteConnection("DataSource=:memory:");
        private readonly IMeetingRepository _meetingRepository;

        public TestMeetingRepository()
        {
            _connection.Open();
            var options = new DbContextOptionsBuilder<MeetingRepository>()
                    .UseSqlite(_connection)
                    .Options;
            _meetingRepository = new MeetingRepository(options);

            //create in-mem db schema 
            using (var context = new MeetingRepository(options))
            {
                context.Database.EnsureCreated();
            }
        }

        [Fact]
        public async void TestDataAddition()
        {

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

            //Act
            var result =  await _meetingRepository.AddMeetings(rootmeeting);


            //Assert
            Assert.True(result);
        }
    }
}
