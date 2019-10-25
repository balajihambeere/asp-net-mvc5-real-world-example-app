using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Connect2Library.Models
{
    public class Connect2LibraryContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Connect2LibraryContext() : base("name=Connect2LibraryContext")
        {
        }

        public System.Data.Entity.DbSet<Connect2Library.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.Supplier> Suppliers { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.BookIssue> BookIssues { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.Photo> Photos { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Connect2Library.Models.Role> Roles { get; set; }
    }
}
