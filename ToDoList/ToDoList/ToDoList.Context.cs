﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ToDoListEntities : DbContext
    {
        public ToDoListEntities()
            : base("name=ToDoListEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TaskManager> TaskManagers { get; set; }
        public virtual DbSet<IDList> IDLists { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
