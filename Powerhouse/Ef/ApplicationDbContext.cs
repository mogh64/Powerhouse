using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Powerhouse.Ef
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
            :base("PHConnection")
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<UserAccount> userAccounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}