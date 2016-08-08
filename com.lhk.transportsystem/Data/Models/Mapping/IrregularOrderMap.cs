using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class IrregularOrderMap : EntityTypeConfiguration<IrregularOrder>
    {
        public IrregularOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sender_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.sender_phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.sender_id_card_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.sender_address)
                .IsRequired();

            this.Property(t => t.recipient_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.recipient_phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.recipient_id_card_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.recipient_address)
                .IsRequired();

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

            this.Property(t => t.confirmation_user_id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IrregularOrder");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.sender_name).HasColumnName("sender_name");
            this.Property(t => t.sender_phone).HasColumnName("sender_phone");
            this.Property(t => t.sender_id_card_no).HasColumnName("sender_id_card_no");
            this.Property(t => t.sender_address).HasColumnName("sender_address");
            this.Property(t => t.recipient_name).HasColumnName("recipient_name");
            this.Property(t => t.recipient_phone).HasColumnName("recipient_phone");
            this.Property(t => t.recipient_id_card_no).HasColumnName("recipient_id_card_no");
            this.Property(t => t.recipient_address).HasColumnName("recipient_address");
            this.Property(t => t.tour_id).HasColumnName("tour_id");
            this.Property(t => t.total_quantity).HasColumnName("total_quantity");
            this.Property(t => t.total_value).HasColumnName("total_value");
            this.Property(t => t.total_cost).HasColumnName("total_cost");
            this.Property(t => t.order_status).HasColumnName("order_status");
            this.Property(t => t.payment_status).HasColumnName("payment_status");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.closed_date).HasColumnName("closed_date");
            this.Property(t => t.confirmation_user_id).HasColumnName("confirmation_user_id");
        }
    }
}
