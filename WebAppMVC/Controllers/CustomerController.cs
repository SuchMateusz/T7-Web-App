using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Application.Services;

namespace WebAppMVC.Controllers
{
    public class CustomerController : Controller
    {
        CustomerService customerService;

        public IActionResult Index()
        {
            var model = customerService.GetAllCustomerForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerModel model)
        {
            var id = customerService.AddCustomer(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewAddressForCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAddressForCustomer(AddressModel model)
        {
            var id = customerService.AddAddressModel(model);
            return View(model);
        }

        public IActionResult GetAddressCustomerDetails(int customerId)
        {
            var model = customerService.GetAddressCustomerDetails(customerId);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomerContactInformaction()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomerContactInformaction (ContactInformationModel model) 
        { 
            var id = customerService.AddCustomerContactInformaction(model);
            return View(model);
        }

        public IActionResult ViewCustomer(int custmerId)
        {
            var customerModel = customerService.GetCustomerDetails(custmerId);
            return View(customerModel);
        }
    }
}
