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

        // GET: DueDate
        public ActionResult Index()
        {
            var dueDate = from a in db.TaskManagers
                           join b in db.IDLists on a.ID equals b.TaskManagerID

                           where a.DueDate == DateTime.Today

                          select new 
                           {
                              dueDateDisplay= a,
                              taskDue = a.DueDate 
                     
                           };

            return View(dueDate);
        }
    }
}