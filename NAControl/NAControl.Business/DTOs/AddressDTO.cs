using System.Collections.Generic;

namespace NAControl.Business.DTOs
{
    public class AddressDTO
    {
        public int AddId { get; set; }

        public string Addresses { get; set; }

        public string Complement { get; set; }

        public int Number { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public virtual IEnumerable<GroupDTO> Group { get; set; }
    }
}