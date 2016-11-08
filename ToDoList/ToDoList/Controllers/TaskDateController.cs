using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Controllers
{
    public class TaskDateController : Controller
    {
        ToDoListEntities db = new ToDoListEntities();

        // GET: DueDate
        public ActionResult Index()
        {
            var dueDate = from a in db.TaskManagers
                          where a.DueDate != null

                          select new ToDoList.Models.TaskDate
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
                          where a.DueDate == tom && a.CompletionDate == tom
                          select new ToDoList.Models.TaskDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate,
                              completedTask = a.CompletionDate

                          };


            return View(dueDate);

        }
        public ActionResult DueTomIncomp()
        {
            DateTime tom = DateTime.Today.AddDays(1);
            var dueDate = from a in db.TaskManagers
                          where a.DueDate == tom && a.CompletionDate == null
                          select new ToDoList.Models.TaskDate
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
                          where a.DueDate == DueToday && a.CompletionDate == DueToday
                          select new ToDoList.Models.TaskDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate,
                              completedTask = a.CompletionDate
                          };


            return View(dueDate);

        }

        public ActionResult DueTodayIncomp()
        {
            DateTime DueToday = DateTime.Today;
            var dueDate = from a in db.TaskManagers
                          where a.DueDate == DueToday && a.CompletionDate == null
                          select new ToDoList.Models.TaskDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate
                          };


            return View(dueDate);

        }
        public ActionResult AllDueToday()
        {
            DateTime DueToday = DateTime.Today;
            var dueDate = from a in db.TaskManagers
                          where a.DueDate == DueToday
                          select new ToDoList.Models.TaskDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate,
                              completedTask = a.CompletionDate

                          };


            return View(dueDate);

        }

        public ActionResult AllDueTom()
        {
            DateTime tom = DateTime.Today.AddDays(1);
            var dueDate = from a in db.TaskManagers
                          where a.DueDate == tom
            select new ToDoList.Models.TaskDate
                          {
                              dueDateDisplay = a,
                              taskDue = a.DueDate,
                              completedTask = a.CompletionDate

                          };


            return View(dueDate);

        }






    }
}