using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Application.Services;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult ViewAccountDetails(int Id)
        {
            return View();
        }

        public IActionResult ViewAllAccounts()
        {

            return View();
        }
    }
}