using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class AuditTrailDetailMap : EntityTypeConfiguration<AuditTrailDetail>
    {
        public AuditTrailDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.parent_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.property_name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AuditTrailDetail");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.parent_id).HasColumnName("parent_id");
            this.Property(t => t.property_name).HasColumnName("property_name");
            this.Property(t => t.old_value).HasColumnName("old_value");
            this.Property(t => t.new_value).HasColumnName("new_value");
        }
    }
}
