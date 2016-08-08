using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class RegularOrderMap : EntityTypeConfiguration<RegularOrder>
    {
        public RegularOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sender_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.recipient_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tour_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.order_status)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.payment_status)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.created_by)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RegularOrder");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.sender_id).HasColumnName("sender_id");
            this.Property(t => t.recipient_id).HasColumnName("recipient_id");
            this.Property(t => t.tour_id).HasColumnName("tour_id");
            this.Property(t => t.total_quantity).HasColumnName("total_quantity");
            this.Property(t => t.total_value).HasColumnName("total_value");
            this.Property(t => t.total_cost).HasColumnName("total_cost");
            this.Property(t => t.order_status).HasColumnName("order_status");
            this.Property(t => t.payment_status).HasColumnName("payment_status");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.closed_date).HasColumnName("closed_date");
        }
    }
}
