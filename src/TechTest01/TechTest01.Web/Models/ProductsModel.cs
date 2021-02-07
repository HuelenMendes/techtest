using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechTest01.Web.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Slug { get; set; }
        
    }
}