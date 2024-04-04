using myShop.Data.Models;
using System.Collections.Generic;

namespace myShop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> getAllCars { get; set; }
        public string currCategory { get; set; }
    }
}
