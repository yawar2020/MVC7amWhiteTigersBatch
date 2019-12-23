using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            return "hello world";
        }

        public ActionResult About()
        {
            ViewBag.info = "Hello World";

            return View("~/Views/home/Index.cshtml");
        }

        [Route("pizza/bakery")]
        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult EmployeeInfo()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1;
            obj.EmpName = "sindu";
            obj.Salary = 21000;

            ViewBag.Details = obj;

            return View();
        }

        public ActionResult GetAllEmployeeInfo()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1;
            obj.EmpName = "sindu";
            obj.Salary = 21000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.Empid = 2;
            obj1.EmpName = "Hima";
            obj1.Salary = 31000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.Empid = 3;
            obj2.EmpName = "Anand";
            obj2.Salary = 41000;

            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);


            List<DepartmentModel> listdeptobj = new List<DepartmentModel>();


            DepartmentModel deptobj = new DepartmentModel();
            deptobj.Deptid = 1;
            deptobj.DeptName = "IT";


            DepartmentModel deptobj1 = new DepartmentModel();
            deptobj1.Deptid = 2;
            deptobj1.DeptName = "Network";


            listdeptobj.Add(deptobj);
            listdeptobj.Add(deptobj1);


            ViewBag.Details = listobj;
            ViewBag.DepartmentDetails = listdeptobj;



            return View();
        }

        public ActionResult setEmployee()
        {
            ViewBag.info = "Hello World";
            return RedirectToAction("index", "home");
        }
        public ActionResult getEmployee()
        {
            return View();
        }
        public ActionResult redirectToGoogle()
        {
            // return Redirect("http://www.google.com");
            return Redirect("~/Default/EmployeeInfo");
        }
        public ActionResult setTaste()
        {

            return RedirectToAction("getTaste");
        }

        public ActionResult getTaste()
        {

            return View();
        }

        public ActionResult getEmpDetail()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1;
            obj.EmpName = "pooja";
            return View(obj);
        }

        public ActionResult getAllEmpDetail()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.Empid = 1;
            obj.EmpName = "pooja";

            EmployeeModel obj1 = new EmployeeModel();
            obj1.Empid = 2;
            obj1.EmpName = "Raja";

            EmployeeModel obj2 = new EmployeeModel();
            obj2.Empid = 3;
            obj2.EmpName = "Tiwari";

            List<EmployeeModel> listobj = new List<Models.EmployeeModel>();
            listobj.Add(obj);
            listobj.Add(obj1);
            listobj.Add(obj2);



            DepartmentModel deptobj = new DepartmentModel();
            deptobj.Deptid = 1;
            deptobj.DeptName = "IT";

            DepartmentModel deptobj1 = new DepartmentModel();
            deptobj1.Deptid = 1;
            deptobj1.DeptName = "Network";

            List<DepartmentModel> listdeptobj = new List<DepartmentModel>();
            listdeptobj.Add(deptobj);
            listdeptobj.Add(deptobj1);

            EmpDept objempdept = new Models.EmpDept();
            objempdept.emp = listobj;
            objempdept.dept = listdeptobj; 

            return View(objempdept);


        }
    }
}