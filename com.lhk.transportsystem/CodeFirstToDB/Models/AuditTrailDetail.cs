using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class AuditTrailDetail
    {
        public string id { get; set; }
        public string parent_id { get; set; }
        public string property_name { get; set; }
        public string old_value { get; set; }
        public string new_value { get; set; }
    }
}