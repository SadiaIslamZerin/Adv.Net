
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class MyPortfolioController : Controller
    {
        // GET: MyPortfolio
        public ActionResult Welcome()
        {
            return View();
        }
        public ActionResult Home()
        {
            string name = "Sadia Islam Zerin";
            string email = "zerin2552@gmail.com";
            string bio = "I'm a student of AIUB";
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;

            return View();
        }
        public new ActionResult Profile()
        {
            MyProfile mp = new MyProfile();
            mp.name = "Sadia Islam Zerin";
            mp.dob = "16 February, 2000";
            mp.nati = "Bangladeshi";
            mp.bloodg = "O+";
            mp.address = "Uttara-Dhaka";
            mp.contno = "019********";
            mp.hobby = "Sleeping";

            return View(mp);
        }
        public ActionResult Education()
        {
            MyEducation e1 = new MyEducation();
            e1.degree = "BSC";
            e1.inst = "AIUB";
            e1.year = "10th Semester";
            MyEducation e2 = new MyEducation();
            e2.degree = "HSC";
            e2.inst = "Milestone College";
            e2.year = "2019";
            MyEducation e3 = new MyEducation();
            e3.degree = "SSC";
            e3.inst = "Milestone School & College";
            e3.year = "2017";
            object[] edu = new object[] { e1, e2, e3 };
            ViewBag.EDU = edu;

            return View();
        }
        public ActionResult Projects()
        {
            MyProjects prj1 = new MyProjects();
            prj1.course = "C#";
            prj1.description = "School Management System";
            MyProjects prj2 = new MyProjects();
            prj2.course = "Web Tech";
            prj2.description = "VMS Sytem";
            var myproject = new MyProjects[] { prj1, prj2 };

            return View(myproject);
        }
        public ActionResult References()
        {
            string name = "XYZ";
            string contact = "017********";
            ViewBag.Rname = name;
            ViewBag.Rcontact = contact;

            return View();
        }
    }
}