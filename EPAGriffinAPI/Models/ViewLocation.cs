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
    
    public partial class ViewLocation
    {
        public string Parent { get; set; }
        public string ParentCode { get; set; }
        public string Root { get; set; }
        public string RootCode { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleFormated { get; set; }
        public string Code { get; set; }
        public string FullCode { get; set; }
        public int CustomerId { get; set; }
        public int TypeId { get; set; }
        public string Remark { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Website { get; set; }
        public Nullable<int> RootLocation { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public string SortName { get; set; }
        public string Type { get; set; }
        public Nullable<int> Items { get; set; }
        public int HasItems { get; set; }
        public Nullable<int> Employees { get; set; }
    }
}
