using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.WebApi.Models
{
    public class AdressModel
    {
        public AdressModel()
        {

        }
       
        public AdressModel(string address, string complement, string city, double latitude, double longitude)
        {
            this.Addresses = address;
        }

        public int AddId { get; private set; }

        public string Addresses { get; private set; }

        public string Complement { get; private set; }

        public int Number { get; private set; }

        public string City { get; private set; }

        public int ZipCode { get; private set; }

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        public GroupModel GroupModel { get; private set; }
    }
}