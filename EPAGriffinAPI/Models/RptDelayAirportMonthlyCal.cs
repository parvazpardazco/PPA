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
    
    public partial class RptDelayAirportMonthlyCal
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string MonthName { get; set; }
        public int Month { get; set; }
        public int AirportId { get; set; }
        public string Airport { get; set; }
        public int Delay { get; set; }
        public Nullable<int> DelayTotal { get; set; }
        public Nullable<decimal> DelayTotalRatio { get; set; }
        public int PreDelay { get; set; }
        public Nullable<decimal> DelayDiff { get; set; }
        public int Count { get; set; }
        public int PreCount { get; set; }
        public Nullable<decimal> CountDiff { get; set; }
        public Nullable<decimal> CountPerLeg { get; set; }
        public decimal PreCountPerLeg { get; set; }
        public Nullable<decimal> CountPerLegDiff { get; set; }
        public Nullable<decimal> DelayPerLeg { get; set; }
        public decimal PreDelayPerLeg { get; set; }
        public Nullable<decimal> DelayPerLegDiff { get; set; }
        public Nullable<decimal> DelayPerBL { get; set; }
        public decimal PreDelayPerBL { get; set; }
        public Nullable<decimal> DelayPerBLDiff { get; set; }
        public Nullable<int> OnTimeFlightCount { get; set; }
        public int PreOnTimeFlightCount { get; set; }
        public Nullable<decimal> OnTimeFlightCountDiff { get; set; }
        public Nullable<decimal> DelayedFlightsPerAll { get; set; }
        public decimal PreDelayedFlightsPerAll { get; set; }
        public Nullable<decimal> DelayedFlightsPerAllDiff { get; set; }
        public Nullable<decimal> DelayedFlightsPerOnTime { get; set; }
        public decimal PreDelayedFlightsPerOnTime { get; set; }
        public Nullable<decimal> DelayedFlightsPerOnTimeDiff { get; set; }
        public int DelayUnder30 { get; set; }
        public int PreDelayUnder30 { get; set; }
        public Nullable<decimal> DelayUnder30Diff { get; set; }
        public int DelayOver30 { get; set; }
        public int PreDelayOver30 { get; set; }
        public Nullable<decimal> DelayOver30Diff { get; set; }
        public int Delay3060 { get; set; }
        public int PreDelay3060 { get; set; }
        public Nullable<decimal> Delay3060Diff { get; set; }
        public int Delay60120 { get; set; }
        public int PreDelay60120 { get; set; }
        public Nullable<decimal> Delay60120Diff { get; set; }
        public int Delay120180 { get; set; }
        public int PreDelay120180 { get; set; }
        public Nullable<decimal> Delay120180Diff { get; set; }
        public int DelayOver180 { get; set; }
        public int PreDelayOver180 { get; set; }
        public Nullable<decimal> DelayOver180Diff { get; set; }
        public int DelayOver240 { get; set; }
        public int PreDelayOver240 { get; set; }
        public Nullable<decimal> DelayOver240Diff { get; set; }
        public int DelayUnder30Time { get; set; }
        public int PreDelayUnder30Time { get; set; }
        public Nullable<decimal> DelayUnder30TimeDiff { get; set; }
        public int DelayOver30Time { get; set; }
        public int PreDelayOver30Time { get; set; }
        public Nullable<decimal> DelayOver30TimeDiff { get; set; }
        public int Delay3060Time { get; set; }
        public int PreDelay3060Time { get; set; }
        public Nullable<decimal> Delay3060TimeDiff { get; set; }
        public int Delay60120Time { get; set; }
        public int PreDelay60120Time { get; set; }
        public Nullable<decimal> Delay60120TimeDiff { get; set; }
        public int Delay120180Time { get; set; }
        public int PreDelay120180Time { get; set; }
        public Nullable<decimal> Delay120180TimeDiff { get; set; }
        public int DelayOver180Time { get; set; }
        public int PreDelayOver180Time { get; set; }
        public Nullable<decimal> DelayOver180TimeDiff { get; set; }
        public int DelayOver240Time { get; set; }
        public int PreDelayOver240Time { get; set; }
        public Nullable<decimal> DelayOver240TimeDiff { get; set; }
        public int FltDelayUnder30 { get; set; }
        public int PreFltDelayUnder30 { get; set; }
        public Nullable<decimal> FltDelayUnder30Diff { get; set; }
        public int FltDelayOver30 { get; set; }
        public int PreFltDelayOver30 { get; set; }
        public Nullable<decimal> FltDelayOver30Diff { get; set; }
        public int FltDelay3060 { get; set; }
        public int PreFltDelay3060 { get; set; }
        public Nullable<decimal> FltDelay3060Diff { get; set; }
        public int FltDelay60120 { get; set; }
        public int PreFltDelay60120 { get; set; }
        public Nullable<decimal> FltDelay60120Diff { get; set; }
        public int FltDelay120180 { get; set; }
        public int PreFltDelay120180 { get; set; }
        public Nullable<decimal> FltDelay120180Diff { get; set; }
        public int FltDelayOver180 { get; set; }
        public int PreFltDelayOver180 { get; set; }
        public Nullable<decimal> FltDelayOver180Diff { get; set; }
        public int FltDelayOver240 { get; set; }
        public int PreFltDelayOver240 { get; set; }
        public Nullable<decimal> FltDelayOver240Diff { get; set; }
        public int FlightCount { get; set; }
        public int PreFlightCount { get; set; }
        public Nullable<decimal> FlightCountDiff { get; set; }
        public int AFlightCount { get; set; }
        public int PreAFlightCount { get; set; }
        public Nullable<decimal> AFlightCountDiff { get; set; }
        public int BlockTime { get; set; }
        public int PreBlockTime { get; set; }
        public Nullable<decimal> BlockTimeDiff { get; set; }
        public Nullable<int> ABlockTime { get; set; }
        public int PreABlockTime { get; set; }
        public Nullable<decimal> ABlockTimeDiff { get; set; }
        public int FlightTime { get; set; }
        public int PreFlightTime { get; set; }
        public Nullable<decimal> FlightTimeDiff { get; set; }
        public Nullable<int> AFlightTime { get; set; }
        public int PreAFlightTime { get; set; }
        public Nullable<decimal> AFlightTimeDiff { get; set; }
    }
}
