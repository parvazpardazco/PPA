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
    
    public partial class RptFuelDailyCal
    {
        public string Date { get; set; }
        public string ArgStr { get; set; }
        public Nullable<int> ArgNum { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public string MonthName { get; set; }
        public string DayName { get; set; }
        public Nullable<int> Legs { get; set; }
        public decimal Uplift { get; set; }
        public decimal Used { get; set; }
        public decimal PreUsed { get; set; }
        public Nullable<decimal> UpliftKilo { get; set; }
        public Nullable<decimal> UsedKilo { get; set; }
        public Nullable<decimal> UpliftPerLeg { get; set; }
        public Nullable<decimal> UsedPerLeg { get; set; }
        public Nullable<decimal> UpliftKiloPerLeg { get; set; }
        public Nullable<decimal> UsedKiloPerLeg { get; set; }
        public int TotalPax { get; set; }
        public int TotalPaxAll { get; set; }
        public double Distance { get; set; }
        public double DistanceKM { get; set; }
        public int Weight { get; set; }
        public decimal WeightTone { get; set; }
        public int PaxWeight { get; set; }
        public decimal PaxWeightTone { get; set; }
        public double WeightDistance { get; set; }
        public double WeightDistanceToneKM { get; set; }
        public Nullable<decimal> UpliftPerPax { get; set; }
        public Nullable<System.DateTime> LocalDate { get; set; }
        public Nullable<decimal> UpliftPerWeight { get; set; }
        public Nullable<double> UpliftPerDistance { get; set; }
        public Nullable<double> UpliftPerDistanceKM { get; set; }
        public Nullable<double> UpliftPerWeightDistance { get; set; }
        public Nullable<double> UpliftPerWeightDistanceKM { get; set; }
        public Nullable<decimal> UsedPerPax { get; set; }
        public Nullable<decimal> UsedPerWeight { get; set; }
        public Nullable<double> UsedPerDistance { get; set; }
        public Nullable<double> UsedPerDistanceKM { get; set; }
        public Nullable<double> UsedPerWeightDistance { get; set; }
        public Nullable<double> UsedPerWeightDistanceKM { get; set; }
        public Nullable<decimal> UsedDiff { get; set; }
        public Nullable<decimal> UsedDiffPerLeg { get; set; }
        public Nullable<decimal> UsedDiffPerPax { get; set; }
        public Nullable<decimal> UsedDiffPerWeight { get; set; }
        public Nullable<double> UsedDiffPerDistance { get; set; }
        public Nullable<double> UsedDiffPerWeightDistance { get; set; }
        public Nullable<decimal> UsedDiffPercent { get; set; }
        public Nullable<decimal> UsedDiffPerLegPercent { get; set; }
        public Nullable<decimal> UsedDiffPerPaxPercent { get; set; }
        public Nullable<decimal> UsedDiffPerWeightPercent { get; set; }
        public Nullable<double> UsedDiffPerDistancePercent { get; set; }
        public Nullable<double> UsedDiffPerWeightDistancePercent { get; set; }
        public Nullable<double> UsedPerWeightDistanceToneKM { get; set; }
    }
}