using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult Delete(int id)
        {

            Student.studlist.RemoveAt(id);
            ViewBag.Students = Student.studlist.ToList();
            return RedirectToAction("Show");

        }

        
        public ActionResult Show()
        {
            ViewBag.Students = Student.studlist.ToList();
            return View();
         
        }

        public ActionResult Update(int id)
        {
            ViewBag.id = id;
            ViewBag.data = Student.studlist[id];
            return View();

        }
        public ActionResult FillUPDATE(int id, string yourName, string yourSurname, string yourAge, string yourGroup)
        {
            Student.studlist[id].Name = yourName;
            Student.studlist[id].Surname = yourSurname;
            Student.studlist[id].Age = Convert.ToInt32(yourAge);
            Student.studlist[id].Group = yourGroup;
            return RedirectToAction("Show")
        }



        public ActionResult Insert(string yourName, string yourSurname, string yourAge, string yourGroup)
        {
            var teach = new Student(yourName, yourSurname, Convert.ToInt32(yourAge), yourGroup);
            return View();
            
        }
    }
}