using System.Collections.Generic;
using System.Data.Entity;
using TechTest01.Domain.Catalog;

namespace TechTest01.Domain
{
    public class TechDBInitializer : CreateDatabaseIfNotExists<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            IList<Product> products = new List<Product>();

            products.Add(new Product() { Name = "CLASSIC TEE WHITE NIGHT", Slug = "classic-tee-white-night", Description= "The Classic Tee White Night is a regular fit short sleeve t-shirt. It features a crew neckline, contrast black Lee chest embroidery and is finished in a pure open end cotton jersey. Thanks to it's regular length it looks great tucked into your fave high waisted jeans.", Price=(decimal)59.95, ImageUrl= "https://leejeans.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-leejeans-master-catalog/default/dw9d2b971c/images/L_652098_/L_652098_AM2_3.jpg?sw=600&sh=600" });
            products.Add(new Product() { Name = "HIGH BAGGY NOBLE BLUE", Slug = "high-baggy-noble-blue", Description= "Our most popular new fit the High Baggy is the ultimate relaxed jean. It features a super high rise with a fitted waist that falls into a relaxed body and full leg length profile. Crafted in 100% cotton, it is made up of a light bright blue denim for an authentic 90's look and feel.", Price=(decimal)169.65, ImageUrl= "https://leejeans.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-leejeans-master-catalog/default/dwb4c2ebe9/images/L_657000_/L_657000_QJ3_1.jpg?sw=600&sh=600" });
            products.Add(new Product() { Name = "HIGH MOMS SHORT FROST BLUE", Slug = "high-moms-short-frost-blue", Description = "Our best-selling High Moms Short is a super high rise short with a modest leg length. It hugs the waist but is more relaxed through the seat and leg so it's super comfy to get around in all summer long. It is finished in comfort rigid denim with a touch of stretch, and features in a light, bright washed blue.", Price = (decimal)109.96, ImageUrl = "https://leejeans.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-leejeans-master-catalog/default/dw64b1c41d/images/L_656873_/L_656873_G97_1.jpg?sw=600&sh=600" });
            products.Add(new Product() { Name = "BAGGY JACKET ROSE QUARTZ", Slug = "baggy-jacket-rose-quartz", Description = "Our newest denim fit jacket is made for easy wear, and designed to be worn oversized and slouchy. Constructed in 100% cotton high twill denim with a super soft hand feel, matching stitching and dual front chest pockets", Price = (decimal)179.65, ImageUrl = "https://leejeans.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-leejeans-master-catalog/default/dw43861b9a/images/L_656898_/L_656898_OR8_1.jpg?sw=600&sh=600" });

            context.Products.AddRange(products);

            base.Seed(context);
        }
    }
}
