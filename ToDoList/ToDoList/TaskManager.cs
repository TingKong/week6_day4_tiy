//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoList
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskManager
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskManager()
        {
            this.IDLists = new HashSet<IDList>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IDList> IDLists { get; set; }
    }
}
