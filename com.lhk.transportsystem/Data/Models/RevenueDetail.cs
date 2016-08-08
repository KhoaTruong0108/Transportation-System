using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class RevenueDetail
    {
        public string id { get; set; }
        public string revenue_id { get; set; }
        public string type { get; set; }
        public string object_id { get; set; }
        public string title { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }
        public string created_by { get; set; }
        public System.DateTime created_date { get; set; }
    }
}
