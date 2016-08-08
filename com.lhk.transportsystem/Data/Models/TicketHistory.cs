using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class TicketHistory
    {
        public string id { get; set; }
        public string ticket_id { get; set; }
        public string action { get; set; }
        public System.DateTime changed_date { get; set; }
        public string changed_by { get; set; }
    }
}
