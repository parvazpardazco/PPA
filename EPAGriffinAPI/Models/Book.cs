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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookChapters = new HashSet<BookChapter>();
            this.BookRelatedAircraftTypes = new HashSet<BookRelatedAircraftType>();
            this.BookAutors = new HashSet<BookAutor>();
            this.BookKeywords = new HashSet<BookKeyword>();
            this.BookRelatedEmployees = new HashSet<BookRelatedEmployee>();
            this.BookRelatedStudyFields = new HashSet<BookRelatedStudyField>();
            this.EmployeeBookStatus = new HashSet<EmployeeBookStatu>();
            this.BookFiles = new HashSet<BookFile>();
            this.BookRelatedGroups = new HashSet<BookRelatedGroup>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Nullable<System.DateTime> DateRelease { get; set; }
        public Nullable<int> PublisherId { get; set; }
        public string ISSNPrint { get; set; }
        public string ISSNElectronic { get; set; }
        public string DOI { get; set; }
        public string Pages { get; set; }
        public int CategoryId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Abstract { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DatePublished { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> DateDeadline { get; set; }
        public string Duration { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public string ExternalUrl { get; set; }
        public Nullable<int> NumberOfLessens { get; set; }
        public int TypeId { get; set; }
        public Nullable<int> JournalId { get; set; }
        public string Conference { get; set; }
        public Nullable<int> ConferenceLocationId { get; set; }
        public string DateConference { get; set; }
        public string Sender { get; set; }
        public string No { get; set; }
        public string PublishedIn { get; set; }
        public string INSPECAccessionNumber { get; set; }
        public string Edition { get; set; }
        public string DateEffective { get; set; }
        public Nullable<int> FolderId { get; set; }
        public Nullable<int> Issue { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public Nullable<System.DateTime> DateValidUntil { get; set; }
        public string BookKey { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookChapter> BookChapters { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookRelatedAircraftType> BookRelatedAircraftTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAutor> BookAutors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookKeyword> BookKeywords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookRelatedEmployee> BookRelatedEmployees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookRelatedStudyField> BookRelatedStudyFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeBookStatu> EmployeeBookStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookFile> BookFiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookRelatedGroup> BookRelatedGroups { get; set; }
    }
}
