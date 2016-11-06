using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class DueDate
    {
            [DisplayName("Due Today")]
            public TaskManager dueDateDisplay { get; set; }



            [DisplayName("Date Rented")]
            //[PlaceHolder("01/01/2016")]
            [Required(ErrorMessage = "You must enter a rental date")]
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
             public Nullable<System.DateTime> taskDue { get; set; }

            ToDoListEntities db = new ToDoListEntities();



        
    }
}