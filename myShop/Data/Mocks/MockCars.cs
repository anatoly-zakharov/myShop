using myShop.Data.Interfaces;
using myShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla",
                        shortDesc = "Быстрый автомомбиль",
                        longDesc = "Красивый быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/ford.jpg",
                        price = 11000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/bmw.jpg",
                        price = 65000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car {
                        name = "Mercedes C Class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/mers.jpg",
                        price = 40000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.First()}
                };
            }
        }



        public IEnumerable<Car> getFavCars { get ; set; }


        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
