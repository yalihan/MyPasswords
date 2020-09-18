using MyPasswords.Business.Abstract;
using MyPasswords.Business.Concrete;
using MyPasswords.DAL.Abstract;
using MyPasswords.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>();
            Bind<IUserDao>().To<EfUserDao>();

            Bind<IEmailService>().To<EmailManager>();
            Bind<IEmailDao>().To<EfEmailDao>();

            Bind<ISiteService>().To<SiteManager>();
            Bind<ISiteDao>().To<EfSiteDao>();
        }
    }
}
