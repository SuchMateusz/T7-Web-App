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
            var accounts = CreateAccounts();
            var account = accounts.FindAll(p => p.IdCustomer == Id);
            return View(account);
        }
        public IActionResult ViewAllAccounts()
        {
            var accounts = CreateAccounts();
            return View(accounts);
        }

        private List<Users> CreateAccounts()
        {
            List<Users> accounts = new List<Users>();
            accounts.Add(new Users { IdCustomer = 1, NameCustomer = "Mateusz", ZipCode = "40-231", City = "Warsaw" });
            accounts.Add(new Users { IdCustomer = 2, NameCustomer = "Daniel", ZipCode = "23-121", City = "Wrocław" });
            accounts.Add(new Users { IdCustomer = 3, NameCustomer = "Agnieszka", ZipCode = "40-231", City = "Warsaw" });
            accounts.Add(new Users { IdCustomer = 4, NameCustomer = "Dominika", ZipCode = "57-321", City = "Lublin" });
            return accounts;
        }
    }
}