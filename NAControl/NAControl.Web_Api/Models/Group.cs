using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.Web_Api.Models
{
    public class Group
    {
        #region Ctor

        public Group() { }

        public Group(string name, Address address)
        {
            this.Name = name;
            this.Address = address;
        }

        #endregion

        #region Properties

        public int GroId { get;  set; }

        public string Name { get;  set; }

        public virtual Address Address { get; set; }

        public ICollection<Meeting> MeetingList { get; set; }

        #endregion

    }
}