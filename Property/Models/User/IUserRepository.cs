using Property.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Models.User
{
    public interface IUserRepository
    {
        void AddUser(User model);
        bool UserLogin(LoginViewModel model);
    }
}
