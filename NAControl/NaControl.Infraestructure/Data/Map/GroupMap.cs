using NAControl.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NAControl.Infraestructure.Data.Map
{
    public class GroupMap:EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            ToTable("Group");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(60)
                .IsRequired();

            HasRequired(x => x.Address)
            .WithRequiredPrincipal();
        }
    }
}
