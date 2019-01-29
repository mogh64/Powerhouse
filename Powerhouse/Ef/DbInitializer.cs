using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Powerhouse.Ef
{
    public class DbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        public DbInitializer()
        {
           
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.userAccounts.AddOrUpdate(
                new UserAccount() {Id=1,UserName="mortaza.ghahremani@gmail.com",Password="admin123"}
            );
            context.SaveChanges();
            base.Seed(context);
        }
    }
}