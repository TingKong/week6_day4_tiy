using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ToDoList;

namespace ToDoList.Controllers
{
    public class IDListsController : Controller
    {
        private ToDoListEntities db = new ToDoListEntities();

        // GET: IDLists
        public ActionResult Index()
        {
            var iDLists = db.IDLists.Include(i => i.TaskManager);
            return View(iDLists.ToList());
        }

        // GET: IDLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IDList iDList = db.IDLists.Find(id);
            if (iDList == null)
            {
                return HttpNotFound();
            }
            return View(iDList);
        }

        // GET: IDLists/Create
        public ActionResult Create()
        {
            ViewBag.TaskManagerID = new SelectList(db.TaskManagers, "ID", "Title");
            return View();
        }

        // POST: IDLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskManagerID,UserName")] IDList iDList)
        {
            if (ModelState.IsValid)
            {
                db.IDLists.Add(iDList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TaskManagerID = new SelectList(db.TaskManagers, "ID", "Title", iDList.TaskManagerID);
            ViewBag.TaskManagerID = new SelectList(db.TaskManagers, "ID", "Title", iDList.TaskManagerID);

            return View(iDList);
        }

        // GET: IDLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IDList iDList = db.IDLists.Find(id);
            if (iDList == null)
            {
                return HttpNotFound();
            }
            ViewBag.TaskManagerID = new SelectList(db.TaskManagers, "ID", "Title", iDList.TaskManagerID);
            return View(iDList);
        }

        // POST: IDLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskManagerID,UserName")] IDList iDList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iDList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TaskManagerID = new SelectList(db.TaskManagers, "ID", "Title", iDList.TaskManagerID);
            return View(iDList);
        }

        // GET: IDLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IDList iDList = db.IDLists.Find(id);
            if (iDList == null)
            {
                return HttpNotFound();
            }
            return View(iDList);
        }

        // POST: IDLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IDList iDList = db.IDLists.Find(id);
            db.IDLists.Remove(iDList);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
