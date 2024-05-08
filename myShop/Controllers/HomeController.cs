using Microsoft.AspNetCore.Mvc;
using myShop.Data.Interfaces;
using myShop.ViewModels;


namespace myShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }
        public ViewResult Index()
        {
            var HomeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            ViewBag.Title = "Главная страница";
            return View(HomeCars);
        }
    }
}
