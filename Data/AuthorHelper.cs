using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class AuthorHelper
    {
        Model.BookLibraryEntities context;

        public Authors GetAuthorById(int idAutor)
        {
            Authors dataTorReturn = new Authors();
            using (context = new BookLibraryEntities())
            {

                dataTorReturn = context.Authors.FirstOrDefault(x => x.Id == idAutor);

            }
            return dataTorReturn;
        }

        public IList<Authors> GetAllAuthors()
        {
            IList<Authors> listTorReturn = new List<Authors>();
            using (context = new BookLibraryEntities())
            {

                listTorReturn = context.Authors.ToList();

            }
            return listTorReturn;
        }
    }
}
