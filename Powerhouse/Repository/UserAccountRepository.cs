using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Powerhouse.Ef;
using Powerhouse.Models;

namespace Powerhouse.Repository
{
    public class UserAccountRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserAccountRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public UserViewModel Login(string userName, string password)
        {
           
            var user = applicationDbContext.userAccounts.FirstOrDefault(it => it.UserName == userName);
            if (user == null)
            {
            
                return new UserViewModel(Microsoft.AspNet.Identity.Owin.SignInStatus.Failure);
            }
            if (!string.Equals(user.Password, password))
            {
                
                return new UserViewModel(Microsoft.AspNet.Identity.Owin.SignInStatus.RequiresVerification);

            }
            
            
            
            return new UserViewModel(Microsoft.AspNet.Identity.Owin.SignInStatus.Success) { Id=user.Id,UserName=user.UserName}; 

        }
    }
}