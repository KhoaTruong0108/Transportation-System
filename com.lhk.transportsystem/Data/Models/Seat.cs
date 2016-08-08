using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Seat
    {
        public string id { get; set; }
        public string bus_id { get; set; }
        public int seat_number { get; set; }
        public string seat_class { get; set; }
        public decimal price { get; set; }
        public int type { get; set; }
    }
}
