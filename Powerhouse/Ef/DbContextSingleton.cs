using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powerhouse.Ef
{
    public class DbContextSingleton
    {
      
        private DbContextSingleton()
        {
            
        }
        public static ApplicationDbContext Instance
        {
            get
            {
                return Nested.Instance;
            }
        }
        private class Nested
        {
            static Nested()
            {

            }
            internal static readonly ApplicationDbContext Instance = new ApplicationDbContext();
        }
       
    }

  
}