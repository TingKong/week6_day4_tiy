using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Controllers
{
    public class DueDateController : Controller
    {
        ToDoListEntities db = new ToDoListEntities();
        DateTime tom = DateTime.Today.AddDays(1);

        // GET: DueDate
        public ActionResult Index()
        {
            var dueDate = from a in db.TaskManagers
                          join b in db.IDLists on a.ID equals b.TaskManagerID
                         

                          where a.DueDate == tom

            select new ToDoList.Models.DueDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate

                          };

            return View(dueDate);
        }
    }
}