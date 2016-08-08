using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class User
    {
        public string id { get; set; }
        public string staff_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public System.DateTime created_date { get; set; }
        public string created_by { get; set; }
        public string role { get; set; }
        public bool active_status { get; set; }
        public bool deleted { get; set; }
    }
}
