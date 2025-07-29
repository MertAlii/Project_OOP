using Microsoft.AspNetCore.Mvc;
using Project_OOP.Entity;
using Project_OOP.ProjeContext;

namespace Project_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if(customer.CustomerName != "" && customer.CustomerCity != "" && customer.CustomerSurname != "")
            {
                context.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Hatalı Bilgi Girişi";
                return View();
            }

        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            context.Customers.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            if (customer.CustomerName != "" && customer.CustomerCity != "" && customer.CustomerSurname != "")
            { 
                var value = context.Customers.Where(x => x.CustomerId == customer.CustomerId).FirstOrDefault();
                value.CustomerName = customer.CustomerName;
                value.CustomerSurname = customer.CustomerSurname;
                value.CustomerCity = customer.CustomerCity;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Error = "Hatalı Bilgi Girişi";
                return View();
            }
        }

    }
}
