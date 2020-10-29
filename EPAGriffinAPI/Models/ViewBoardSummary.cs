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
    
    public partial class ViewBoardSummary
    {
        public System.DateTime Date { get; set; }
        public Nullable<int> TotalFlight { get; set; }
        public Nullable<int> Departed { get; set; }
        public Nullable<int> Arrived { get; set; }
        public Nullable<int> Diverted { get; set; }
        public Nullable<int> Canceled { get; set; }
        public int BlockTime { get; set; }
        public int FlightTimeActual { get; set; }
        public int FlightTime { get; set; }
        public int FixTime { get; set; }
        public int SITATime { get; set; }
        public int Delay { get; set; }
        public int Pax { get; set; }
        public int PaxAdult { get; set; }
        public int PaxChild { get; set; }
        public int PaxInfant { get; set; }
        public decimal PaxLoad { get; set; }
        public int TotalSeat { get; set; }
        public int BaggageWeight { get; set; }
        public int CargoWeight { get; set; }
        public int BaggageCount { get; set; }
        public int CargoCount { get; set; }
        public decimal FuelActual { get; set; }
        public decimal FuelUplift { get; set; }
    }
}
