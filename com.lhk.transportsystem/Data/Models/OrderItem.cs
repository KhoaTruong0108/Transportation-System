using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class OrderItem
    {
        public string id { get; set; }
        public string order_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal value { get; set; }
        public string size { get; set; }
        public double weight { get; set; }
        public decimal cost { get; set; }
        public string description { get; set; }
        public string order_item_number { get; set; }
    }
}
