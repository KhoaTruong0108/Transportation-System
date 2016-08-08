using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.staff_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.user_name)
                .IsRequired();

            this.Property(t => t.password)
                .IsRequired();

            this.Property(t => t.created_by)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.role)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.staff_id).HasColumnName("staff_id");
            this.Property(t => t.user_name).HasColumnName("user_name");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.active_status).HasColumnName("active_status");
            this.Property(t => t.deleted).HasColumnName("deleted");
        }
    }
}
