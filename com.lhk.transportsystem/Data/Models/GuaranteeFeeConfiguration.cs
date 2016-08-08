using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class GuaranteeFeeConfiguration
    {
        public string id { get; set; }
        public decimal value_from { get; set; }
        public decimal value_to { get; set; }
        public decimal guarantee_fee { get; set; }
    }
}
