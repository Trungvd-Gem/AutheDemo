﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutheDemo.Models;

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
            ViewData["employees"] = employeeRepository.Gets();
            return View();
        }

        public ViewResult Details(int id)
        {
            /*ViewBag.Employee = employeeRepository.Get(id);*/
            var employee = employeeRepository.Get(id);
            return View(employee);
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
