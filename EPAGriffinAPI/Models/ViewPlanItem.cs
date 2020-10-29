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
    
    public partial class ViewPlanItem
    {
        public int Id { get; set; }
        public int taskId { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public string Day { get; set; }
        public int FromAirport { get; set; }
        public int ToAirport { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public System.DateTime Dep { get; set; }
        public System.DateTime startDateUTC { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public System.DateTime Arr { get; set; }
        public Nullable<System.DateTime> STD { get; set; }
        public Nullable<System.DateTime> STA { get; set; }
        public int TypeId { get; set; }
        public string AircraftType { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string FlightNumber { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public int progress { get; set; }
        public Nullable<decimal> duration { get; set; }
        public int EstimatedDelay { get; set; }
        public int DelayOffBlock { get; set; }
        public int DelayTakeoff { get; set; }
        public int DelayOnBlock { get; set; }
        public int DelayLanding { get; set; }
        public int IsDelayOffBlock { get; set; }
        public int IsDelayTakeoff { get; set; }
        public int IsDelayOnBlock { get; set; }
        public int IsDelayLanding { get; set; }
        public Nullable<int> FlightH { get; set; }
        public Nullable<int> FlightM { get; set; }
        public string Line { get; set; }
    }
}
