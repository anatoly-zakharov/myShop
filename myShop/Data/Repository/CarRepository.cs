using Microsoft.EntityFrameworkCore;
using myShop.Data.Interfaces;
using myShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace myShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Cars.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Cars.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Cars.FirstOrDefault(i => i.id == carId);
    }
}
