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
    
    public partial class ViewAirport
    {
        public string Name { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }
        public int CityId { get; set; }
        public int Id { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public string SortName { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<int> SortIndex { get; set; }
    }
}
