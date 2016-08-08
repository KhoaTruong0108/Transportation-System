using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class TransportPriceConfigurationMap : EntityTypeConfiguration<TransportPriceConfiguration>
    {
        public TransportPriceConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.size)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TransportPriceConfiguration");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.size).HasColumnName("size");
            this.Property(t => t.weight_from).HasColumnName("weight_from");
            this.Property(t => t.weight_to).HasColumnName("weight_to");
            this.Property(t => t.transport_price).HasColumnName("transport_price");
        }
    }
}
