using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Views
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Charles";
            employee.Salary = 5000;
            return View(employee);
           
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        public ActionResult UpdateEmployee()
        {
            return View();
        }
    }
}