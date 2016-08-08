using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class ConfigurationMap : EntityTypeConfiguration<Configuration>
    {
        public ConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.value)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Configuration");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
