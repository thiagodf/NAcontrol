using NAControl.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NAControl.Infraestructure.Data.Map
{
    public class AddressMap:EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("Address");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Addresses)
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Complement)
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Number)
                .IsRequired();

            Property(x => x.City)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.ZipCode)
                .IsRequired();
            
            Property(x => x.Latitude);

            Property(x => x.Longitude);
        }
    }
}
