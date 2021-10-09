using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Customer 1", Id=1 },
                new Customer { Name = "Customer 2", Id=2 }
            };
        List<Customer> noCustomers = new List<Customer>();
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            try
            {
                return View(customers[id - 1]);
            }
            catch
            {
                return HttpNotFound();
            }
        }
    }
}