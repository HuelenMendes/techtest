using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;

namespace TechTest01.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductService service = null;
        public ProductController()
        {
            service = new ProductService();
        }
        public ProductController(ProductService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var products = this.service.GetProducts().ToArray();
            return View(products);
        }
    }
}