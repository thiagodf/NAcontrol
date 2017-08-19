using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.WebApi.Models
{
    public class MeetingModel
    {
        public MeetingModel()
        {

        }
        public int MeeId { get; private set; }

        public bool Private { get; private set; }

        public DayOfWeek Day { get; private set; }

        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }

        public GroupModel GroupModel { get; set; }
    }
}