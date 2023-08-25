using Microsoft.AspNetCore.Mvc;
using ShyamBank.EFPersistancelayer;
using ShyamBank.Models;
using System.Collections.Generic;

namespace ShyamBank.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult create(Employee employee) {
            bool IsSuccess = EFEmployeeContext.Create(employee);
            if(IsSuccess )
            {
                return RedirectToAction("List");
            }
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            List<Employee> employee = EFEmployeeContext.GetEmployees( );
            return View(employee);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            Employee loggedInUser = EFEmployeeContext.Login(userName, password);
            if (loggedInUser == null)
            {
                ViewBag.EmployeeData = new Employee() { UserName = userName };
                ViewBag.ErroMessage = "Invalid credentials";
                return View();
            }

            return RedirectToAction("List");
        }
    }
}
