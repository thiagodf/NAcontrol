using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.Web_Api.Models
{
    public class Address
    {
        public Address()
        {

        }
        //public Address(string address, string complement, string city, double latitude, double longitude)
        //{
        //    this.Addresses = address;
        //}

        public int AddId { get; set; }

        public string Addresses { get; set; }

        public string Complement { get;  set; }

        public int Number { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public Group Group { get; set; }
    }
}