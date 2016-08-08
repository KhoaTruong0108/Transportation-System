using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Expense
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }
        public string created_by { get; set; }
        public System.DateTime created_date { get; set; }
    }
}
