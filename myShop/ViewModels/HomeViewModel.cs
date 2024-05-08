using myShop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace myShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
    }
}
