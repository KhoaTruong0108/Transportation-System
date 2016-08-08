using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class SeatMap : EntityTypeConfiguration<Seat>
    {
        public SeatMap()
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

            this.Property(t => t.seat_class)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Seat");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.bus_id).HasColumnName("bus_id");
            this.Property(t => t.seat_number).HasColumnName("seat_number");
            this.Property(t => t.seat_class).HasColumnName("seat_class");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
