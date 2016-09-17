using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Business
{
    public class AuthorBusiness
    {
        static AuthorHelper helper = new AuthorHelper();

        public static IList<Authors> GetAllAuthors()
        {
            return helper.GetAllAuthors();
        }

        public static Authors GetAuthorById(int idAuthor)
        {
            return helper.GetAuthorById(idAuthor);
        }

       
    }
}
