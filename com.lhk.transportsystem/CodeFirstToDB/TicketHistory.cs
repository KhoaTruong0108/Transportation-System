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
    
    public partial class TicketHistory
    {
        public string id { get; set; }
        public string ticket_id { get; set; }
        public string action { get; set; }
        public System.DateTime changed_date { get; set; }
        public string changed_by { get; set; }
    }
}
