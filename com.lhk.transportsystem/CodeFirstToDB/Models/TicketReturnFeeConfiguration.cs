using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class TicketReturnFeeConfiguration
    {
        public string id { get; set; }
        public int before_day { get; set; }
        public int before_hour { get; set; }
        public int fee_percent { get; set; }
        public decimal fee_amount { get; set; }
    }
}
