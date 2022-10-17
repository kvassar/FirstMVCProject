using FirstMVCProject.Models;
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
            List<Employee> employeeList = new List<Employee>();
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Charles";
            employee.Salary = 5000;
            employeeList.Add(employee);
            Employee emp2 = new Employee();
            emp2.ID = 2;
            emp2.Name = "Bernard";
            emp2.Salary = 4000;
            employeeList.Add(emp2);
            return View(employeeList);
           
        }
        public JsonResult GetDateWithJHson()
        {
            string JsonDate = DateTime.Today.ToShortDateString();
            return Json(JsonDate);
        }
        public ActionResult AddEmployee()
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            return View();
        }
        public ActionResult UpdateEmployee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Charels";
            employee.Salary = 7000;
            return View(employee);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}