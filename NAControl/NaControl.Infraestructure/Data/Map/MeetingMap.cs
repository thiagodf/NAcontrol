using NAControl.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NAControl.Infraestructure.Data.Map
{
    public class MeetingMap:EntityTypeConfiguration<Meeting>
    {
        public MeetingMap()
        {
            ToTable("Meeting");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Private)
                .IsRequired();

            Property(x => x.Start)
              .IsRequired();

            Property(x => x.End)
            .IsRequired();

            Property(x => x.Day)
            .IsRequired();

            HasRequired(x => x.Group)
            .WithRequiredPrincipal();
        }
    }
}
