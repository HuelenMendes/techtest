using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;
using TechTest01.Services.Catalog;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    
    public class ProductController : Controller
    {

        private IProductService service = null;
        
        public ProductController(IProductService service)
        {
            this.service = service;
        }
        
        public ActionResult Index(string slug)
        {
            ProductDetailsModel details;
            var product = this.service.GetBySlug(slug);
            if (product == null)
            {
                return new HttpNotFoundResult();
            }

            details = new ProductDetailsModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Slug = product.Slug,
                ImageUrl = product.ImageUrl
            };

            return View(details);
        }
       
    }
}