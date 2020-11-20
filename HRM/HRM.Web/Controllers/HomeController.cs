using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "EmployeeDetails"
            };
            return View(homeDetailsViewModel);
        }
    }
}
