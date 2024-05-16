using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using myShop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace myShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any()) {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Cars.Any()) {
                content.Cars.AddRange(

                     new Car
                     {
                         name = "Tesla",
                         shortDesc = "Быстрый автомомбиль",
                         longDesc = "Красивый быстрый и очень тихий автомобиль компании Tesla",
                         img = "/img/tesla.jpg",
                         price = 45000,
                         isFavorite = true,
                         avaliable = true,
                         Category = Categories["Электромобили"]
                     },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/ford.jpg",
                        price = 11000,
                        isFavorite = true,
                        avaliable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/bmw.jpg",
                        price = 65000,
                        isFavorite = true,
                        avaliable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes C Class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/mers.jpg",
                        price = 40000,
                        isFavorite = true,
                        avaliable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavorite = true,
                        avaliable = true,
                        Category = Categories["Электромобили"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get {
                if(category == null)
                {
                    var list = new Category[]
                    {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }
                return category;
            }
        }
    }
}
