//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingCurriculum
{
    using System;
    using System.Collections.Generic;
    
    public partial class group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public group()
        {
            this.group1 = new HashSet<group>();
            this.trainings = new HashSet<training>();
            this.users = new HashSet<user>();
        }
    
        public short id { get; set; }
        public Nullable<short> parent_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<group> group1 { get; set; }
        public virtual group group2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<training> trainings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
