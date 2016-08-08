using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class BusMap : EntityTypeConfiguration<Bus>
    {
        public BusMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Bus");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.seat_count).HasColumnName("seat_count");
            this.Property(t => t.sub_seat_count).HasColumnName("sub_seat_count");
            this.Property(t => t.bed_count).HasColumnName("bed_count");
            this.Property(t => t.sub_bed_count).HasColumnName("sub_bed_count");
        }
    }
}
