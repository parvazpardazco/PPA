//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAGriffinAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OffItem
    {
        public int FDPId { get; set; }
        public int FlightId { get; set; }
        public string Remark { get; set; }
    
        public virtual FlightInformation FlightInformation { get; set; }
        public virtual FDP FDP { get; set; }
    }
}
