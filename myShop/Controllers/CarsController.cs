using Microsoft.AspNetCore.Mvc;
using myShop.Data.Interfaces;

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
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
