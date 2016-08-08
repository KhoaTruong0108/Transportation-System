using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.order_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.size)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired();

            this.Property(t => t.order_item_number)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("OrderItem");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.size).HasColumnName("size");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.order_item_number).HasColumnName("order_item_number");
        }
    }
}
