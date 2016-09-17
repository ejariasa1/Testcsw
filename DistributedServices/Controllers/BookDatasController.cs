using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Business;
using Model;


namespace DistributedServices.Controllers
{
    public class BookDatasController : ApiController
    {

        public IList<BookDatas> GetAllBooks()
        {
            return BookBusiness.GetAllBooks();
        }

        public IList<BookDatas> GetBooksByCategory(int idCategory)
        {
            return BookBusiness.GetBooksByCategory(idCategory);
        }

        public IList<BookDatas> GetBooksByAuthor(int idAuthor)
        {
            return BookBusiness.GetBooksByCategory(idAuthor);
        }
    }
}
