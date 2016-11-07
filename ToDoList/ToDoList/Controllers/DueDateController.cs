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
                          where a.DueDate != null

                          select new ToDoList.Models.DueDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate
                          };


            return View(dueDate);
        }

        public ActionResult DueTom()
        {
            DateTime tom = DateTime.Today.AddDays(1);
            var dueDate = from a in db.TaskManagers
                          where a.DueDate == tom
                          select new ToDoList.Models.DueDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate
                          };


            return View(dueDate);

        }

        public ActionResult DueToday()
        {
            DateTime DueToday = DateTime.Today;
            var dueDate = from a in db.TaskManagers
                          where a.DueDate == DueToday
                          select new ToDoList.Models.DueDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate
                          };


            return View(dueDate);

        }
    }
}