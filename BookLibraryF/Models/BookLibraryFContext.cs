using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookLibraryF.Models
{
    public class BookLibraryFContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BookLibraryFContext() : base("name=BookLibraryFContext")
        {
        }

        public System.Data.Entity.DbSet<Model.BookDatas> BookDatas { get; set; }

        public System.Data.Entity.DbSet<Model.Authors> Authors { get; set; }

        public System.Data.Entity.DbSet<Model.Categories> Categories { get; set; }
    }
}
