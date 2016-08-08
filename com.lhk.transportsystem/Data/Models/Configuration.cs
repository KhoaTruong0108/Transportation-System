using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Configuration
    {
        public string id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string description { get; set; }
    }
}
