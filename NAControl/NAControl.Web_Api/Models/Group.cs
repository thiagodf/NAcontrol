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

        public Group(string name, Address adress)
        {
            this.Name = name;
            this.Adress = adress;
        }

        #endregion

        #region Properties

        public int GroId { get; private set; }

        public string Name { get; private set; }

        public virtual Address Adress { get; private set; }

        public ICollection<Meeting> MeetingList { get; set; }

        #endregion

    }
}