using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CodeFirstToDB.Models.Mapping;

namespace CodeFirstToDB.Models
{
    public partial class ThanhVanTranSysContext : DbContext
    {
        static ThanhVanTranSysContext()
        {
            Database.SetInitializer<ThanhVanTranSysContext>(null);
        }

        public ThanhVanTranSysContext()
            : base("Name=ThanhVanTranSysContext")
        {
        }

        public DbSet<AuditTrail> AuditTrails { get; set; }
        public DbSet<AuditTrailDetail> AuditTrailDetails { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<FinishedTour> FinishedTours { get; set; }
        public DbSet<GuaranteeFeeConfiguration> GuaranteeFeeConfigurations { get; set; }
        public DbSet<IrregularOrder> IrregularOrders { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<OrderHistoryDetail> OrderHistoryDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<RegularOrder> RegularOrders { get; set; }
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<RevenueDetail> RevenueDetails { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
        public DbSet<TicketPriceConfiguration> TicketPriceConfigurations { get; set; }
        public DbSet<TicketReturnFeeConfiguration> TicketReturnFeeConfigurations { get; set; }
        public DbSet<TicketSaleDate> TicketSaleDates { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TransportPriceConfiguration> TransportPriceConfigurations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuditTrailMap());
            modelBuilder.Configurations.Add(new AuditTrailDetailMap());
            modelBuilder.Configurations.Add(new BusMap());
            modelBuilder.Configurations.Add(new ConfigurationMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ExpenseMap());
            modelBuilder.Configurations.Add(new FinishedTourMap());
            modelBuilder.Configurations.Add(new GuaranteeFeeConfigurationMap());
            modelBuilder.Configurations.Add(new IrregularOrderMap());
            modelBuilder.Configurations.Add(new OrderHistoryMap());
            modelBuilder.Configurations.Add(new OrderHistoryDetailMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
            modelBuilder.Configurations.Add(new RegularOrderMap());
            modelBuilder.Configurations.Add(new RevenueMap());
            modelBuilder.Configurations.Add(new RevenueDetailMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new StaffMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TicketHistoryMap());
            modelBuilder.Configurations.Add(new TicketPriceConfigurationMap());
            modelBuilder.Configurations.Add(new TicketReturnFeeConfigurationMap());
            modelBuilder.Configurations.Add(new TicketSaleDateMap());
            modelBuilder.Configurations.Add(new TourMap());
            modelBuilder.Configurations.Add(new TransportPriceConfigurationMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
