using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.Serialization;

namespace TimeTableClientSide
{
    [DataContract]
    public class Timetable
    {
        [Key]
        [DataMember(Name = "Timetable_Id")]
        public int Timetable_Id { get; set; }
        [DataMember(Name = "StartTime")]
        public DateTime StartTime { get; set; }
        [DataMember(Name = "EndTime")]
        public DateTime EndTime { get; set; }
        [DataMember(Name = "Room")]
        public Room Room { get; set; }
        [DataMember(Name = "Calendar")]
        public Calendar Calendar { get; set; }

        [ForeignKey("Calendar_Id")]
        public int Calendar_Id { get; set; }

        [ForeignKey("Room_Id")]
        public int Room_Id { get; set; }

    }


    [DataContract]
    public class Room
    {
        [Key]
        [DataMember(Name = "Room_Id")]
        public int Room_Id { get; set; }

        [DataMember(Name = "Room_no")]
        public int Room_no { get; set; }

        [DataMember(Name = "message")]
        public string Description { get; set; }
    }

    [DataContract]
    public class Calendar
    {
        [Key]
        [DataMember(Name = "Calendar_Id")]
        public int Calendar_Id { get; set; }
        [DataMember(Name = "CalendarDate")]
        public DateTime CalendarDate { get; set; }
        [DataMember(Name = "DayofWeek")]
        public string DayofWeek { get; set; }
        [DataMember(Name = "WeekNumber")]
        public int WeekNumber { get; set; }

    }
}
