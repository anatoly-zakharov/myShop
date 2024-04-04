using Microsoft.AspNetCore.Mvc;
using myShop.Data.Interfaces;
using myShop.ViewModels;

namespace myShop.Controllers
{
    public class CarsController : Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
