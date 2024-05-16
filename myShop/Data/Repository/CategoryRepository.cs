using myShop.Data.Interfaces;
using myShop.Data.Models;
using System.Collections.Generic;

namespace myShop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        public readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Categories;
    }
}
