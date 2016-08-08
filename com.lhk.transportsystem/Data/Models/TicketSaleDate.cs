using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TicketSaleDate
    {
        public string id { get; set; }
        public int ticket_sale_day { get; set; }
        public int ticket_sale_month { get; set; }
        public int ticket_sale_year { get; set; }
        public int before_days { get; set; }
    }
}
