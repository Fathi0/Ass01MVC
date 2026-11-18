using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController:Controller
    {
        //BaseUrl/Products/GetProductById
        public Product GetProductById(int id)
        {
            return new Product() { Id = 1, Name = "Laptop", Salary = 20 };
        }
    }
}
