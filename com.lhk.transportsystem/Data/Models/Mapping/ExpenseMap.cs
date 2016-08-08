using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class ExpenseMap : EntityTypeConfiguration<Expense>
    {
        public ExpenseMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.description)
                .IsRequired();

            this.Property(t => t.created_by)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Expense");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.created_by).HasColumnName("created_by");
            this.Property(t => t.created_date).HasColumnName("created_date");
        }
    }
}
