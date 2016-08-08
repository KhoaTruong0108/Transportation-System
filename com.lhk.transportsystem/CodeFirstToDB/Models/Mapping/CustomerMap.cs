using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.company)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.id_card_number)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.mobile)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.address1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.address2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.created_by)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.id_card_number).HasColumnName("id_card_number");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.mobile).HasColumnName("mobile");
            this.Property(t => t.address1).HasColumnName("address1");
            this.Property(t => t.address2).HasColumnName("address2");
            this.Property(t => t.created_date).HasColumnName("created_date");
            this.Property(t => t.created_by).HasColumnName("created_by");
        }
    }
}
