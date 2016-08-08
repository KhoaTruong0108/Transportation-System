using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class TourMap : EntityTypeConfiguration<Tour>
    {
        public TourMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.start)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.destination)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tour");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.start).HasColumnName("start");
            this.Property(t => t.destination).HasColumnName("destination");
            this.Property(t => t.travel_time).HasColumnName("travel_time");
        }
    }
}
