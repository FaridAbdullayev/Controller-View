using FirstAppHomework.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppHomework.Controllers
{
    public class HomeController:Controller
    {
        private List<Product> _products;

        public HomeController()
        {
            _products = new List<Product> { 
                new Product { Id=1,Name="Iphone11",Price=9,Description="2019 satisa cixib"},
                new Product { Id=2,Name="Nokia",Price=3,Description="Ancaq zeng ucun"} ,
                new Product { Id=3,Name="Samsung24",Price=20,Description="2024 satisa cixib"} ,
                new Product { Id=4,Name="Fly",Price=5,Description="Gunluk istifade ucun"} ,
                new Product { Id=5,Name="Mac",Price=11,Description="Dizayn ucun"} ,
                new Product { Id=6,Name="iphone12",Price=20,Description="2020 satisa cixib"} 
            };
        }


        public JsonResult Detail(int id)
        {
            foreach (var item in _products)
            {
                if(item.Id == id)
                    return Json(item);
            }
            return null;
        }

        public ViewResult Index()
        {
            ViewBag.Products = _products;

            return View();
        }
    }
}
