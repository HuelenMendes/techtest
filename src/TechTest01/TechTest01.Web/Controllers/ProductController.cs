using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    
    public class ProductController : Controller
    {

        private ProductService service = null;
        public ProductController()
        {
            service = new ProductService();
        }
        public ProductController(ProductService service)
        {
            this.service = service;
        }

        //[Route("Product/{slug}")]
        public ActionResult Index(string slug)
        {
            ProductDetailsModel details;
            var product = this.service.GetBySlug(slug);
            if (product == null)
            {
                return new HttpNotFoundResult();
            }
            
            details = new ProductDetailsModel();
            details.Id = product.Id;
            details.Name = product.Name;
            details.Description = product.Description;
            details.Price = product.Price;
            details.Slug = product.Slug;
            details.ImageUrl = product.ImageUrl;


            ViewBag.Title = product.Slug;

            return View(details);
        }
       
    }
}