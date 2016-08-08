using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class Ticket
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string bus_id { get; set; }
        public string tour_id { get; set; }
        public string passenger_name { get; set; }
        public string passenger_id_card_no { get; set; }
        public string phone { get; set; }
        public int seat_number { get; set; }
        public string seat_class { get; set; }
        public decimal cost { get; set; }
        public System.DateTime departure_time { get; set; }
        public string status { get; set; }
        public System.DateTime created_date { get; set; }
    }
}
