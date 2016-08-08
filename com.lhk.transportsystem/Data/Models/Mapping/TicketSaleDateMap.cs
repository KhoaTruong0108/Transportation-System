using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class TicketSaleDateMap : EntityTypeConfiguration<TicketSaleDate>
    {
        public TicketSaleDateMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TicketSaleDate");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ticket_sale_day).HasColumnName("ticket_sale_day");
            this.Property(t => t.ticket_sale_month).HasColumnName("ticket_sale_month");
            this.Property(t => t.ticket_sale_year).HasColumnName("ticket_sale_year");
            this.Property(t => t.before_days).HasColumnName("before_days");
        }
    }
}
