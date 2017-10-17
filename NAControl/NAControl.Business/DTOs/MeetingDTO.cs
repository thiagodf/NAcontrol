using System;

namespace NAControl.Business.DTOs
{
    public class MeetingDTO
    {
        public int MeeId { get; set; }

        public bool Private { get; set; }

        public DayOfWeek Day { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public GroupDTO Group { get; set; }
    }
}