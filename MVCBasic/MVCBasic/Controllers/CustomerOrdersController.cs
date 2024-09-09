using Microsoft.AspNetCore.Mvc;
using MVCBasic.Models;
using MVCBasic.ViewModels;

namespace MVCBasic.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {

            //Customer nesnesi oluşturma
            var customer = new Customer()
            {
                Id = 1,
                FirstName = "Ajda",
                LastName = "Pekkan",
                Email = "ajda@gmail.com"
            };

           //orders listesine Order nesneleri ekleme
            var orders = new List<Order>();

            orders.Add(new Order
            {   Id = 1,
                ProductName = "Telefon",
                Price = 55000,
                Quantity = 2,
            });

            orders.Add(new Order
            {   Id = 2,
                ProductName = "Çanta",
                Price = 120000,
                Quantity = 1,
            });


            

            var viewModel = new CustomerOrderViewModel()
            {
                Customer = customer,
                Orders = orders
            };


            return View(viewModel);
        }
    }
}
