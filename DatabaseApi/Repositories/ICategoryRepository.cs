using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Category CreateCategory(Category category);
        Category GetCategoryById(int id);
        Category GetCategoryByName(string name);
        Category UpdateCategory(int id, Category category);
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Category> GetAllCategoriesByIds(IEnumerable<int> ids);
    }
}
