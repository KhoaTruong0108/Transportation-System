using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class AuditTrail
    {
        public string id { get; set; }
        public string object_id { get; set; }
        public string object_type { get; set; }
        public string action { get; set; }
        public System.DateTime date_time { get; set; }
        public string user_id { get; set; }
    }
}
