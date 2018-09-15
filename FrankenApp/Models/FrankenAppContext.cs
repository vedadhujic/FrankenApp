using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        public DbSet<Proba> Probe { get; set; }
        public DbSet<Proba2> Probe2 { get; set; }
        public DbSet<Proba3> Probe3 { get; set; }
        public DbSet<Proba4> Probe4 { get; set; }
        public DbSet<Jednina> Jednine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}