﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Application.Services;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_itemService = itemService;
        }

        public IActionResult Index()
        {
            return View();
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