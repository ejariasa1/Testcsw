using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Business
{
    public class CategoryBusiness
    {
        static CategoryHelper helper = new CategoryHelper();

        public static IList<Categories> GetAllCategories()
        {
            return helper.GetAllCategories();
        }

        public static Categories GetCategoryById(int idCategory)
        {
            return helper.GetCategoryById(idCategory);
        }
    }
}
