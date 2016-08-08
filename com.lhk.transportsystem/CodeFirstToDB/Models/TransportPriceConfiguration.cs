using System;
using System.Collections.Generic;

namespace CodeFirstToDB.Models
{
    public partial class TransportPriceConfiguration
    {
        public string id { get; set; }
        public string size { get; set; }
        public double weight_from { get; set; }
        public double weight_to { get; set; }
        public decimal transport_price { get; set; }
    }
}
