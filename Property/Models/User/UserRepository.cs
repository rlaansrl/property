
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Property.DataContext;
using Property.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Models.User
{
    public class UserRepository :IUserRepository
    {
        
        public void AddUser(User model)
        {
            using(var db = new PropertyDbContext())
            {
                model.UserInsertDate = DateTime.Now;
                db.Users.Add(model);
                db.SaveChanges();
            }

        }

        public bool UserLogin(LoginViewModel model)
        {
            using (var db = new PropertyDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId.Equals(model.UserId) && u.UserPw.Equals(model.UserPw));
                if(user != null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool UserIdCheck(string id)
        {
            using (var db = new PropertyDbContext())
            {
                var checkId = db.Users.FirstOrDefault(ID => ID.UserId.Equals(id));
                if (checkId == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
