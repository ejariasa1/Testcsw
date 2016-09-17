using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Business
{
   public class BookBusiness
    {
        static BookHelper helper = new BookHelper();

        public static IList<BookDatas> GetAllBooks()
        {
            return helper.GetAllBooks();
        }

        public static IList<BookDatas> GetBooksByCategory(int idCategory)
        {
            return helper.GetBooksByCategory(idCategory);
        }

        public static IList<BookDatas> GetBooksByAuthor(int idAuthor)
        {
            return helper.GetBooksByAuthor(idAuthor);
        }

    }
}
