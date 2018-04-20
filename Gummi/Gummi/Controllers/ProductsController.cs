using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gummi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gummi.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        private GummiContext db = new GummiContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }
    }
}
