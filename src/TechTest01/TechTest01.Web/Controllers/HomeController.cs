using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Services;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {
        private ProductService service = null;

        public HomeController() {
            service = new ProductService();
        }

        public HomeController(ProductService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var randomProducts = new HomeModel();

            var products = this.service.GetProducts().ToArray();           
            
            if (products != null && products.Length > 1)
            {
                var rnd = new Random();
                var rndIndex1 = rnd.Next(0, products.Length);
                var rndIndex2 = rndIndex1;
                while (rndIndex1 == rndIndex2)
                {
                    rndIndex2 = rnd.Next(0, products.Length);
                }

                randomProducts.Product1 = products[rndIndex1];
                randomProducts.Product2 = products[rndIndex2];
            }
            else if (products != null && products.Length == 1)
            {                
                randomProducts.Product1 = products[0];
            }

            return View(randomProducts);
        }
    }
}