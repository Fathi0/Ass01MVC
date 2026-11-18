using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController:Controller
    {
        //BaseUrl/Products/GetProductById
        public Product GetProductById(int id)
        {
            return new Product() { Id = 1, Name = "Laptop", Price = 20 };
        }
        //Actions : Public Non-Static (Object Mamber Function) Methods
        //Acttion Results : Built-in DataType Used As Return Type For Actions
        //BaseUrl/Products/GetProducts
[HttpGet] //-->Defult
        //public List<Product> GetProducts()
        //{
        //    //logic
        //    return new List<Product>()
        //    {
        //        new Product(){Id=1,Name="P1",Price=100},
        //        new Product(){Id=2,Name="P2",Price=130},
        //        new Product(){Id=3,Name="P3",Price=110},

        //    };
        //}
        //verb--> Get,Post,Patch,Delete

        public JsonResult GetProducts()
        {
            //logic
            return new JsonResult(new List<Product>()
            {
                new Product(){Id=1,Name="P1",Price=100},
                new Product(){Id=2,Name="P2",Price=130},
                new Product(){Id=3,Name="P3",Price=110},

            });
        }
        public ViewResult Index()
        {
            return new ViewResult(); //HTML Pages
        }
        public FileContentResult DownloadFile()
        {
            var bytes = System.IO.File.ReadAllBytes("wwwroot/Fils/note.txt");
            return new FileContentResult(bytes,"application/txt");
        }
        public RedirectResult RedirctToUrl()
        {
            return new RedirectResult("https://www.Google.com");
        }
        public RedirectToActionResult RedirctAction()
        {
            return new RedirectToActionResult("RedirctToUrl", "Products", null);
        }
        //Parent 
        public IActionResult Test(int id)
        {
            if (id == 1)
                return  View();
            else if (id == 2)
                return  Json(new Product() { Id = 1, Name = "Laptop", Price = 20 });
            else if (id == 3)
                return  Redirect("https://www.facebook.com");
            else
                return  View();
        }


    }
}
