using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FrankenApp.Models
{
    public class FrankenAppContext : DbContext
    {
        public FrankenAppContext() : base("name=FrankenAppConnection")
        {

        }

        public DbSet<User> Users { get; set; }

    }
}