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
    
    public partial class ViewFlightRoute
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public int FromAirportId { get; set; }
        public string FromAirportIATA { get; set; }
        public string FromAirportName { get; set; }
        public int ToAirportId { get; set; }
        public string ToAirportIATA { get; set; }
        public string ToAirportName { get; set; }
        public string Title { get; set; }
        public Nullable<int> Stops { get; set; }
        public string Equipment { get; set; }
        public Nullable<int> FlightH { get; set; }
        public Nullable<int> FlightM { get; set; }
        public Nullable<decimal> ToAirportLatitude { get; set; }
        public Nullable<decimal> ToAirportLongitude { get; set; }
        public Nullable<decimal> FromAirportLatitude { get; set; }
        public Nullable<decimal> FromAirportLongitude { get; set; }
        public Nullable<int> FromCityId { get; set; }
        public string FromCity { get; set; }
        public string FromCountry { get; set; }
        public int FromCountryId { get; set; }
        public string FromSortName { get; set; }
        public Nullable<int> ToCityId { get; set; }
        public string ToCity { get; set; }
        public int ToCountryId { get; set; }
        public string ToSortName { get; set; }
        public string ToCountry { get; set; }
    }
}
