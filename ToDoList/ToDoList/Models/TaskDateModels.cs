using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class TaskDate
    {
            [DisplayName("Tasks")]
            public TaskManager dueDateDisplay { get; set; }



            [DisplayName("Due Date")]
            //[PlaceHolder("01/01/2016")]
            [Required(ErrorMessage = "You must enter a rental date")]
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime taskDue { get; set; }


        [DisplayName("Completed Date")]
        //[PlaceHolder("01/01/2016")]
        [Required(ErrorMessage = "You must enter a rental date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime? completedTask { get; set; }

        ToDoListEntities db = new ToDoListEntities();




    }
}