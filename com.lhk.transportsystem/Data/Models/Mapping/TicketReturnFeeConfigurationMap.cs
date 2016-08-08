using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class TicketReturnFeeConfigurationMap : EntityTypeConfiguration<TicketReturnFeeConfiguration>
    {
        public TicketReturnFeeConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TicketReturnFeeConfiguration");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.before_day).HasColumnName("before_day");
            this.Property(t => t.before_hour).HasColumnName("before_hour");
            this.Property(t => t.fee_percent).HasColumnName("fee_percent");
            this.Property(t => t.fee_amount).HasColumnName("fee_amount");
        }
    }
}
