using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutheDemo.Models;
using AutheDemo.ViewModels;

namespace AutheDemo.Controllers
{
    public class HomeController : Controller
    {
       /* private readonly ILogger<HomeController> _logger;*/
        private IEmployeeRepository employeeRepository;

        public HomeController()
        {
            employeeRepository = new EmployeeRepository();
        }

        public ViewResult Index()
        {
            /*ViewData["employees"] = employeeRepository.Gets();*/
            var employees = employeeRepository.Gets();
            return View(employees);
        }

        public ViewResult Details(int id)
        {
            /*ViewBag.Employee = employeeRepository.Get(id);*/
           /* var employee = employeeRepository.Get(id);
            ViewBag.TitleName = "Employee Detail";*/
            var detailViewModel = new HomeDetailViewModel()
            {
                Employee = employeeRepository.Get(id),
                TitleName = "Employee Detail"

            };
            return View(detailViewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
