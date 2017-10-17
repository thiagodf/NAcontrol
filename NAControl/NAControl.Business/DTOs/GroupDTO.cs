using System.Collections.Generic;

namespace NAControl.Business.DTOs
{
    public class GroupDTO
    {
        public int GroId { get; set; }

        public string Name { get; set; }

        public virtual AddressDTO Address { get; set; }

        public ICollection<MeetingDTO> MeetingList { get; set; }
    }
}