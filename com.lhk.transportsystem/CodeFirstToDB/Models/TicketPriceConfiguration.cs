using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class TicketPriceConfiguration
    {
        public string id { get; set; }
        public string seat_class { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
