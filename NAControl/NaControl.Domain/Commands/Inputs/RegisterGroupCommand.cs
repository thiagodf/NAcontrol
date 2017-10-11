using NAControl.Common.Commands;
using NAControl.Domain.Models;
using System.Collections.Generic;

namespace NAControl.Domain.Commands.Inputs
{
    public class RegisterGroupCommand: ICommand
    {
        public int GroId { get; set; }

        public string Name { get; set; }

        public virtual Address Address { get; set; }

        public ICollection<Meeting> MeetingList { get; set; }
    }
}
