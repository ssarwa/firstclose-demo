using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace firstclose_demo.Models
{
    public class MyDatabaseContext: DbContext
    {
        public MyDatabaseContext() : base("name=MyDbConnection")
        {
        }

        public System.Data.Entity.DbSet<firstclose_demo.Models.Todo> Todoes { get; set; }
    }
}