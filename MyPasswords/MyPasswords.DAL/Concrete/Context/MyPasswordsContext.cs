using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.DAL.Concrete.Context
{
    public class MyPasswordsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Site> Sites { get; set; }
    }
}
