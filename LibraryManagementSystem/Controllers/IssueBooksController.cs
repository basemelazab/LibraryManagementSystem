using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class IssueBooksController : Controller
    {
        private LibraryDBEntities1 db= new LibraryDBEntities1();
        // GET: IssueBooks
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetCustomerId(int id)
        {
            var customerId=(from s in db.Customers where s.Id== id select s.CustomerName).ToList();
            return Json(id, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetBook(int id)
        {
            var books = db.Books.Select(p => new
            {
                Id=p.Id,
                BookName=p.BookName
            }).ToList();
            return Json(books, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Save(IssueBook issue)
        {
            if (ModelState.IsValid)
            {
                db.IssueBooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
        }
    }
}