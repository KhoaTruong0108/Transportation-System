using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class GuaranteeFeeConfigurationMap : EntityTypeConfiguration<GuaranteeFeeConfiguration>
    {
        public GuaranteeFeeConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GuaranteeFeeConfiguration");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.value_from).HasColumnName("value_from");
            this.Property(t => t.value_to).HasColumnName("value_to");
            this.Property(t => t.guarantee_fee).HasColumnName("guarantee_fee");
        }
    }
}
