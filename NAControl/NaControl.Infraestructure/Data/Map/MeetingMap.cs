using NAControl.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NAControl.Infraestructure.Data.Map
{
    public class MeetingMap:EntityTypeConfiguration<Meeting>
    {
        public MeetingMap()
        {
            ToTable("MeeMeeting");

            HasKey(x => x.MeeId);

            Property(x => x.MeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Private)
                .IsRequired();

            Property(x => x.Start)
              .IsRequired();

            Property(x => x.End)
            .IsRequired();

            Property(x => x.Day)
            .IsRequired();

            HasRequired(ad => ad.Group)
                .WithMany(g => g.MeetingList)
              .Map(m => m.MapKey("Mee_GrouId"))
              .WillCascadeOnDelete(true);
        }
    }
}
