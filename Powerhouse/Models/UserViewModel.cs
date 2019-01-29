using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Powerhouse.Models
{
    public class UserViewModel
    {
        public UserViewModel() { }
        public UserViewModel(SignInStatus status) { SignInStatus = status; }
        public SignInStatus SignInStatus { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}