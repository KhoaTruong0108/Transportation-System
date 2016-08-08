using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string id_card_number { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public System.DateTime created_date { get; set; }
        public string created_by { get; set; }
    }
}
