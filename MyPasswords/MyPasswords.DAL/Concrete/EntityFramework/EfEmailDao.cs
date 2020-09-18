using MyPasswords.DAL.Abstract;
using MyPasswords.DAL.Concrete.Context;
using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.DAL.Concrete.EntityFramework
{
    public class EfEmailDao : EfEntityDaoBase<Email,MyPasswordsContext> , IEmailDao
    {
    }
}
