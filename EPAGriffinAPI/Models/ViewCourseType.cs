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
    
    public partial class ViewCourseType
    {
        public int Id { get; set; }
        public Nullable<int> CalenderTypeId { get; set; }
        public Nullable<int> CourseCategoryId { get; set; }
        public Nullable<int> LicenseResultBasicId { get; set; }
        public string Title { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Interval { get; set; }
        public string Interval2 { get; set; }
        public Nullable<bool> IsGeneral { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Category { get; set; }
        public string CalenderType { get; set; }
        public Nullable<int> CoursesCount { get; set; }
    }
}
