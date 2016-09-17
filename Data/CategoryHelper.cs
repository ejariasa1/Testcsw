using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
   public class CategoryHelper
    {
        BookLibraryEntities context;

        public Categories GetCategoryById(int idCategory)
        {
            Categories dataTorReturn = new Categories();
            using (context = new BookLibraryEntities())
            {

                dataTorReturn = context.Categories.FirstOrDefault(x => x.Id == idCategory);

            }
            return dataTorReturn;
        }

        public IList<Categories> GetAllCategories()
        {
            IList<Categories> listTorReturn = new List<Categories>();
            using (context = new BookLibraryEntities())
            {

                listTorReturn = context.Categories.ToList();

            }
            return listTorReturn;
        }
    }
}
