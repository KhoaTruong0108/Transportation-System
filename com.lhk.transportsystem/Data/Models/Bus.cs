using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Bus
    {
        public string id { get; set; }
        public string name { get; set; }
        public int seat_count { get; set; }
        public int sub_seat_count { get; set; }
        public int bed_count { get; set; }
        public int sub_bed_count { get; set; }
    }
}
