//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test1._1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CR_Estimation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CR_Estimation()
        {
            this.Scenarios = new HashSet<Scenario>();
        }
    
        public int id { get; set; }
        public Nullable<int> crm_id { get; set; }
        public string requirement_id { get; set; }
        public string requirement_from_original_id { get; set; }
        public string object_type { get; set; }
    
        public virtual CRM CRM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scenario> Scenarios { get; set; }
    }
}
