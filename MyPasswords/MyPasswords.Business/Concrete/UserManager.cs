using MyPasswords.Business.Abstract;
using MyPasswords.Business.Utilities;
using MyPasswords.Business.ValidationRules.FluentValidation;
using MyPasswords.DAL.Abstract;
using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDao _iUserDao;
        public UserManager(IUserDao iUserDao)
        {
            _iUserDao = iUserDao;
        }


        public List<User> GetAll()
        {
            return _iUserDao.GetAll();
        }
        public User GetUserById(int userId)
        {
            return _iUserDao.Get(p => p.UserId == userId);
        }
        public User GetUserByUsernameAndPassword(string userName,string userPassword)
        {
            return _iUserDao.Get(p => p.UserName.Equals(userName) && p.UserPassword.Equals(userPassword));
        }

        public void Add(User user)
        {
            ValidationTool.Validate(new UserValidator(),user);
            _iUserDao.Add(user);
        }
        public void Update(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _iUserDao.Update(user);
        }
        public void Delete(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _iUserDao.Delete(user);
        }
    }
}
