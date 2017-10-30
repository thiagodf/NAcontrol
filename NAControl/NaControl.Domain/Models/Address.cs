﻿using System.Collections.Generic;

namespace NAControl.Domain.Models
{
    public class Address
    {
        #region Ctor

        public Address()
        {

        }
        public Address(int id, string address,string complement, string city, string latitude, string longitude)
        {
            this.Addresses = address;
            this.Complement = complement;
            this.City = city;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.AddId = id;
        }

        #endregion

        #region Properties

        public int AddId{ get; private set; }

        public string Addresses { get; private set; }

        public string Complement { get; private set; }

        public int Number { get; private set; }

        public string City { get; private set; }

        public int ZipCode { get; private set; }

        public string Latitude { get; private set; }

        public string Longitude { get; private set; }

        public virtual IEnumerable<Group> Group { get; private set; }

        #endregion
    }
}
