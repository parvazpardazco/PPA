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
    
    public partial class ViewBookFile
    {
        public string Title { get; set; }
        public string FileUrl { get; set; }
        public string Remark { get; set; }
        public int DocumentId { get; set; }
        public string SysUrl { get; set; }
        public string FileType { get; set; }
        public Nullable<int> DocumentTypeId { get; set; }
        public Nullable<int> FileTypeId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int BookId { get; set; }
        public int Id { get; set; }
        public Nullable<int> ChapterId { get; set; }
        public string Chapter { get; set; }
    }
}
