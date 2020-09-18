using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetUserById(int userId);
        User GetUserByUsernameAndPassword(string userName,string userPassword);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
