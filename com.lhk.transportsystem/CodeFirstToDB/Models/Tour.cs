using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class Tour
    {
        public string id { get; set; }
        public string start { get; set; }
        public string destination { get; set; }
        public int travel_time { get; set; }
    }
}
