using Powerhouse.Ef;
using Powerhouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerhouse.Repository
{

    public interface IUserRepository
    {
        UserViewModel Login(string userName, string password);
    }
}
