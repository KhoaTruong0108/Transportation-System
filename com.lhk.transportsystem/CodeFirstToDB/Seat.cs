//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFirstToDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seat
    {
        public string id { get; set; }
        public string bus_id { get; set; }
        public int seat_number { get; set; }
        public string seat_class { get; set; }
        public decimal price { get; set; }
        public int type { get; set; }
    }
}
