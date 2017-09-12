using NAControl.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NAControl.Infraestructure.Data.Map
{
    public class GroupMap:EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            ToTable("GroGroup");

            HasKey(x => x.GroId);

            Property(x => x.GroId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(60)
                .IsRequired();

            //HasRequired(p => p.Address)
            // .WithMany()
            // .HasForeignKey(p => p.Grou_AddId);

            HasRequired(x => x.Address)
            .WithMany() 
            .Map(m => m.MapKey("Grou_AddId"));

        }
    }
}
