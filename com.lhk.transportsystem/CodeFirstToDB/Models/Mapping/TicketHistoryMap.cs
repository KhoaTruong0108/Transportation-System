using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class TicketHistoryMap : EntityTypeConfiguration<TicketHistory>
    {
        public TicketHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ticket_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.action)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.changed_by)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TicketHistory");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ticket_id).HasColumnName("ticket_id");
            this.Property(t => t.action).HasColumnName("action");
            this.Property(t => t.changed_date).HasColumnName("changed_date");
            this.Property(t => t.changed_by).HasColumnName("changed_by");
        }
    }
}
