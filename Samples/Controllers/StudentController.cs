using Samples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Samples.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Student student)
        {
            String message = "";
            bool Status = false;
            if (ModelState.IsValid)
            {
                using (MyDatabaseEntities11 dc = new MyDatabaseEntities11())
                {
                    dc.Students.Add(student);
                    dc.SaveChanges();
                    message = "Registration successfully donedonadonedones.";
                    Status = true;
                }
            }
            else
            {
                message = "Invalid Request";
            }
            ViewBag.Message = message;
            ViewBag.Status = Status;
            return View(student);
        }
    }
}