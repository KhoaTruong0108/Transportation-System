using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class FinishedTourMap : EntityTypeConfiguration<FinishedTour>
    {
        public FinishedTourMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bus_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tour_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("FinishedTour");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.total_tickets).HasColumnName("total_tickets");
            this.Property(t => t.total_amount).HasColumnName("total_amount");
            this.Property(t => t.bus_id).HasColumnName("bus_id");
            this.Property(t => t.tour_id).HasColumnName("tour_id");
            this.Property(t => t.finished_date).HasColumnName("finished_date");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
