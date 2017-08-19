using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.WebApi.Models
{
    public class GroupModel
    {
        public GroupModel()
        {

        }
        public int GroId { get; private set; }

        public string Name { get; private set; }

        public virtual AdressModel AdressModel { get; private set; }

        public ICollection<MeetingModel> MeetingList { get; set; }
    }
}