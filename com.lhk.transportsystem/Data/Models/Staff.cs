using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Staff
    {
        public string id { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public string personal_id { get; set; }
        public string position { get; set; }
        public decimal wage { get; set; }
        public System.DateTime join_date { get; set; }
        public string working_status { get; set; }
    }
}
