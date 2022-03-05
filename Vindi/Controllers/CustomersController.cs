using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vindi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vindi.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>() { new Customer() { id = 1, age = 29, name = "Jhalak" }, new Customer() { id = 2, age = 29, name = "Jai" } };

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = customers.Find(c => c.id == id);
            return View(customer);
        }
    }
}
