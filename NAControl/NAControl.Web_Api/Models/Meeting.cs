using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.Web_Api.Models
{
    public class Meeting
    {
        #region Ctor

        public Meeting() { }

        public Meeting(bool _private, DayOfWeek day, DateTime start, DateTime end, Group group)
        {
            this.Private = _private;
            this.Day = day;
            this.Start = start;
            this.End = end;
            this.Group = group;
        }

        #endregion

        #region Properties

        public int MeeId { get; private set; }

        public bool Private { get; private set; }

        public DayOfWeek Day { get; private set; }

        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }

        public Group Group { get; set; }

        #endregion
    }
}