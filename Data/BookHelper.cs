using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;

namespace Data
{
    public class BookHelper
    {
        BookLibraryEntities context;

        public IList<BookDatas> GetBooksByAuthor(int idAuthor)
        {
            IList<BookDatas> listToReturn = new List<BookDatas>();
            using (context = new BookLibraryEntities())
            {
                listToReturn = context.BookDatas.Where(x => x.Authors_Id == idAuthor).ToList();
            }

                return listToReturn;
        }

        public IList<BookDatas> GetBooksByCategory(int IdCategory)
        {
            IList<BookDatas> listToReturn = new List<BookDatas>();
            using (context = new BookLibraryEntities())
            {
                listToReturn = context.BookDatas.Where(x => x.Categories_Id == IdCategory).ToList();
            }

            return listToReturn;
        }

        public IList<BookDatas> GetAllBooks()
        {
            IList<BookDatas> listToReturn = new List<BookDatas>();
            using (context = new BookLibraryEntities())
            {
                listToReturn = (IList<BookDatas>)(from a in context.BookDatas
                               select a).ToList();
            }

            return listToReturn;
        }
    }
}
