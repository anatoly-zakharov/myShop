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
                        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Tesla_Model_3_parked%2C_front_driver_side.jpg/1200px-Tesla_Model_3_parked%2C_front_driver_side.jpg",
                        price = 45000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.First()},
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://cdn.motor1.com/images/mgl/28rKM/s1/ford-fiesta-st-2022.jpg",
                        price = 11000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://cdn.motor1.com/images/mgl/WwpZO/s3/bmw-m3-sedan-render.jpg",
                        price = 65000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car {
                        name = "Mercedes C Class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://images.drive.ru/i/0/6035e81f5b8d72703188633d.jpg",
                        price = 40000,
                        isFavorite = true,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()},
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://motor.ru/imgs/2021/02/01/12/4489384/89827f3f7badbcc844f179158a8bca08f300676f.jpg",
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
