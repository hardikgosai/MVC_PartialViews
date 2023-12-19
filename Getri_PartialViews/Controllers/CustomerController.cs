using Getri_PartialViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace Getri_PartialViews.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerId = 1, CustomerName = "John Doe", CustomerAddress = "123 Main Street", CustomerEmail = "abc@xyz.com" });
            customers.Add(new Customer { CustomerId = 2, CustomerName = "Jane Doe", CustomerAddress = "456 Main Street", CustomerEmail = "adc2tsx.com" });
            customers.Add(new Customer { CustomerId = 3, CustomerName = "John Smith", CustomerAddress = "789 Main Street", CustomerEmail = "kht@sr.com" });
            customers.Add(new Customer { CustomerId = 4, CustomerName = "Jane Smith", CustomerAddress = "101 Main Street", CustomerEmail = "poi@ser.com" });
            customers.Add(new Customer { CustomerId = 5, CustomerName = "John Doe", CustomerAddress = "123 Main Street", CustomerEmail = "qwe@trd.com" });

            List<Products> products = new List<Products>();
            products.Add(new Products { ProductId = 1, ProductName = "Laptop", ProductCategory = "Electronics", Description = "A laptop computer", ProductPrice = 1200 });
            products.Add(new Products { ProductId = 2, ProductName = "TV", ProductCategory = "Electronics", Description = "A television", ProductPrice = 500 });
            products.Add(new Products { ProductId = 3, ProductName = "Sofa", ProductCategory = "Furniture", Description = "A sofa", ProductPrice = 700 });
            products.Add(new Products { ProductId = 4, ProductName = "Chair", ProductCategory = "Furniture", Description = "A chair", ProductPrice = 100 });
            products.Add(new Products { ProductId = 5, ProductName = "Desk", ProductCategory = "Furniture", Description = "A desk", ProductPrice = 300 });

            ViewBag.Products = products;
            return View(customers);
        }
    }
}
