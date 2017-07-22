namespace NAControl.Domain.Models
{
    public class Address
    {
        public Address()
        {

        }
        public Address(string address,string complement, string city, double latitude, double longitude )
        {
            this.Addresses = address;
        }

        public int Id{ get; private set; }

        public string Addresses { get; private set; }

        public string Complement { get; private set; }

        public int Number { get; private set; }

        public string City { get; private set; }

        public int ZipCode { get; private set; }

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }
    }
}
