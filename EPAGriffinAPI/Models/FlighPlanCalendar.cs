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
    
    public partial class FlighPlanCalendar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlighPlanCalendar()
        {
            this.FlightPlanCalanderCrews = new HashSet<FlightPlanCalanderCrew>();
        }
    
        public int Id { get; set; }
        public int FlightPlanId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual FlightPlan FlightPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPlanCalanderCrew> FlightPlanCalanderCrews { get; set; }
    }
}