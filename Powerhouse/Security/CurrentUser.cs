using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powerhouse.Security
{
    public class CurrentUser
    {
        public static bool IsAuthenticated
        {
            get
            {
                return HttpContext.Current.User != null &&
                       HttpContext.Current.User.Identity != null &&
                       HttpContext.Current.User.Identity.IsAuthenticated;
            }
        }
    }
}