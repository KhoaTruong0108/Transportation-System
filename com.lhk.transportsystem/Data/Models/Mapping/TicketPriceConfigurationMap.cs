using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class TicketPriceConfigurationMap : EntityTypeConfiguration<TicketPriceConfiguration>
    {
        public TicketPriceConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.seat_class)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("TicketPriceConfiguration");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.seat_class).HasColumnName("seat_class");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
