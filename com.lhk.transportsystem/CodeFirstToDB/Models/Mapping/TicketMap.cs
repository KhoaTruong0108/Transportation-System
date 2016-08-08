using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstToDB.Models.Mapping
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.user_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bus_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tour_id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.passenger_name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.passenger_id_card_no)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.phone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.seat_class)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.status)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Ticket");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.bus_id).HasColumnName("bus_id");
            this.Property(t => t.tour_id).HasColumnName("tour_id");
            this.Property(t => t.passenger_name).HasColumnName("passenger_name");
            this.Property(t => t.passenger_id_card_no).HasColumnName("passenger_id_card_no");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.seat_number).HasColumnName("seat_number");
            this.Property(t => t.seat_class).HasColumnName("seat_class");
            this.Property(t => t.cost).HasColumnName("cost");
            this.Property(t => t.departure_time).HasColumnName("departure_time");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.created_date).HasColumnName("created_date");
        }
    }
}
