using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using tabcorp.Models.Meeting;
using tabcorp.Repository.Meeting;

namespace tabcorp.Migrations
{
    [DbContext(typeof(MeetingRepository))]
    [Migration("20171016040943_newmodel")]
    partial class newmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("tabcorp.Models.Meeting.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("tabcorp.Models.Meeting.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Endtime");

                    b.Property<int?>("MeetingId");

                    b.Property<string>("Racename");

                    b.Property<int>("Racenumber");

                    b.Property<DateTime>("Starttime");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.ToTable("Race");
                });

            modelBuilder.Entity("tabcorp.Models.Meeting.Race", b =>
                {
                    b.HasOne("tabcorp.Models.Meeting.Meeting")
                        .WithMany("Races")
                        .HasForeignKey("MeetingId");
                });
        }
    }
}
