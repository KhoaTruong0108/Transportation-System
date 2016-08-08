using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class FinishedTour
    {
        public string id { get; set; }
        public int total_tickets { get; set; }
        public decimal total_amount { get; set; }
        public string bus_id { get; set; }
        public string tour_id { get; set; }
        public Nullable<System.DateTime> finished_date { get; set; }
        public string description { get; set; }
    }
}
