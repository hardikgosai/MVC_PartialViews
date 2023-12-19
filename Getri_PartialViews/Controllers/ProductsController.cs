using Getri_PartialViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace Getri_PartialViews.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products { ProductId = 1, ProductName = "Laptop", ProductCategory = "Electronics", Description = "A laptop computer", ProductPrice = 1200 });
            products.Add(new Products { ProductId = 2, ProductName = "TV", ProductCategory = "Electronics", Description = "A television", ProductPrice = 500 });
            products.Add(new Products { ProductId = 3, ProductName = "Sofa", ProductCategory = "Furniture", Description = "A sofa", ProductPrice = 700 });
            products.Add(new Products { ProductId = 4, ProductName = "Chair", ProductCategory = "Furniture", Description = "A chair", ProductPrice = 100 });
            products.Add(new Products { ProductId = 5, ProductName = "Desk", ProductCategory = "Furniture", Description = "A desk", ProductPrice = 300 });

            return View(products);
        }
    }
}
