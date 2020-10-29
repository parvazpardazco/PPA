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
    
    public partial class RptFuelLeg
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> LocalDate { get; set; }
        public string PDate { get; set; }
        public string PYearName { get; set; }
        public Nullable<int> PYear { get; set; }
        public string PMonthName { get; set; }
        public Nullable<int> PMonth { get; set; }
        public string PDayName { get; set; }
        public string PYearMonthName { get; set; }
        public int FlightId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> FlightStatusID { get; set; }
        public Nullable<int> RegisterID { get; set; }
        public string AircraftType { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string FlightNumber { get; set; }
        public Nullable<int> FromAirport { get; set; }
        public Nullable<int> ToAirport { get; set; }
        public Nullable<System.DateTime> ChocksIn { get; set; }
        public Nullable<System.DateTime> Landing { get; set; }
        public Nullable<System.DateTime> Takeoff { get; set; }
        public Nullable<System.DateTime> ChocksOut { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public string Register { get; set; }
        public Nullable<decimal> Defuel { get; set; }
        public Nullable<decimal> FPFuel { get; set; }
        public Nullable<int> TotalPax { get; set; }
        public Nullable<int> FuelUnitID { get; set; }
        public string FuelUnit { get; set; }
        public Nullable<int> CargoUnitID { get; set; }
        public string CargoUnit { get; set; }
        public Nullable<int> CargoCount { get; set; }
        public Nullable<int> BaggageCount { get; set; }
        public Nullable<System.DateTime> STDLocal { get; set; }
        public Nullable<System.DateTime> STALocal { get; set; }
        public Nullable<System.DateTime> STD { get; set; }
        public Nullable<System.DateTime> STA { get; set; }
        public string FlightStatus { get; set; }
        public Nullable<System.DateTime> STDDay { get; set; }
        public Nullable<System.DateTime> STADay { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<System.DateTime> DepartureLocal { get; set; }
        public Nullable<System.DateTime> ArrivalLocal { get; set; }
        public Nullable<System.DateTime> TakeoffLocal { get; set; }
        public Nullable<System.DateTime> LandingLocal { get; set; }
        public Nullable<int> BlockTime { get; set; }
        public Nullable<int> FlightTime { get; set; }
        public Nullable<int> SITATime { get; set; }
        public Nullable<int> PaxChild { get; set; }
        public Nullable<int> PaxInfant { get; set; }
        public Nullable<int> PaxAdult { get; set; }
        public Nullable<decimal> Remaining { get; set; }
        public Nullable<decimal> UpLift { get; set; }
        public Nullable<decimal> Used { get; set; }
        public Nullable<int> TotalSeat { get; set; }
        public int BaggageWeight { get; set; }
        public int CargoWeight { get; set; }
        public Nullable<int> Freight { get; set; }
        public Nullable<decimal> FreightTone { get; set; }
        public Nullable<int> TotalPaxAll { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<decimal> WeightTone { get; set; }
        public Nullable<int> PaxWeight { get; set; }
        public Nullable<decimal> PaxWeightTone { get; set; }
        public string Route { get; set; }
        public Nullable<double> DistanceKM { get; set; }
        public Nullable<double> Distance { get; set; }
        public Nullable<double> WeightDistance { get; set; }
        public Nullable<double> WeightDistanceToneKM { get; set; }
    }
}
