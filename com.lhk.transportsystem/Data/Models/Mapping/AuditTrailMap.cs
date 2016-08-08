using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class AuditTrailMap : EntityTypeConfiguration<AuditTrail>
    {
        public AuditTrailMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.object_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.object_type)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.action)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.user_id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AuditTrail");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.object_id).HasColumnName("object_id");
            this.Property(t => t.object_type).HasColumnName("object_type");
            this.Property(t => t.action).HasColumnName("action");
            this.Property(t => t.date_time).HasColumnName("date_time");
            this.Property(t => t.user_id).HasColumnName("user_id");
        }
    }
}
