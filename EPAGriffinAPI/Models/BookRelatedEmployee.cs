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
    
    public partial class BookRelatedEmployee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BookId { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> DateSigned { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
