using System.Web.Http;
using TechTest01.Services;
using TechTest01.Services.Catalog;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    [RoutePrefix("api/Default")]
    public class DefaultController : ApiController
    {
        //// GET: api/Default
        private readonly IProductService service = null;
        public DefaultController()
        {
            this.service = new ProductService();
        }

        public DefaultController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("GetRandom")]
        public HomeModel GetRandom()
        {            
            HomeController controller = new HomeController(service);
            var randomProducts = controller.Get();
            return randomProducts;
        }

        [HttpGet]
        [Route("GetAll")]
        public ProductsModel[] GetAll()
        {
            ProductsController controller = new ProductsController(service);
            var products = controller.GetAll();
            return products;
        }

        [HttpGet]
        [Route("GetDetail")]
        public ProductDetailsModel GetDetail(string slug)
        {
            ProductController controller = new ProductController(service);
            var products = controller.GetDetail(slug);
            return products;
        }
    }
}
