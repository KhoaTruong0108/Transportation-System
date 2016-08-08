using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class StaffMap : EntityTypeConfiguration<Staff>
    {
        public StaffMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.personal_id)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.position)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.working_status)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Staff");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name1).HasColumnName("name1");
            this.Property(t => t.name2).HasColumnName("name2");
            this.Property(t => t.personal_id).HasColumnName("personal_id");
            this.Property(t => t.position).HasColumnName("position");
            this.Property(t => t.wage).HasColumnName("wage");
            this.Property(t => t.join_date).HasColumnName("join_date");
            this.Property(t => t.working_status).HasColumnName("working_status");
        }
    }
}
