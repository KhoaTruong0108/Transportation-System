using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class IrregularOrder
    {
        public string id { get; set; }
        public string sender_name { get; set; }
        public string sender_phone { get; set; }
        public string sender_id_card_no { get; set; }
        public string sender_address { get; set; }
        public string recipient_name { get; set; }
        public string recipient_phone { get; set; }
        public string recipient_id_card_no { get; set; }
        public string recipient_address { get; set; }
        public string tour_id { get; set; }
        public int total_quantity { get; set; }
        public decimal total_value { get; set; }
        public decimal total_cost { get; set; }
        public string order_status { get; set; }
        public string payment_status { get; set; }
        public System.DateTime created_date { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> closed_date { get; set; }
        public string confirmation_user_id { get; set; }
    }
}
