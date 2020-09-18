using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.DAL.Abstract
{
    public interface IUserDao : IEntityDao<User>
    {
    }
}
