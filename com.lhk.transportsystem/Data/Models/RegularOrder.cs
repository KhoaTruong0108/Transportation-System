using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class RegularOrder
    {
        public string id { get; set; }
        public string sender_id { get; set; }
        public string recipient_id { get; set; }
        public string tour_id { get; set; }
        public int total_quantity { get; set; }
        public decimal total_value { get; set; }
        public decimal total_cost { get; set; }
        public string order_status { get; set; }
        public string payment_status { get; set; }
        public System.DateTime created_date { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> closed_date { get; set; }
    }
}
