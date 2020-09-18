using MyPasswords.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Entities.Concrete
{
    public class Site : IEntity
    {
        public int SiteId { get; set; }
        public int EmailId { get; set; }
        public string SiteName { get; set; }
        public string SiteUserName { get; set; }
        public string SitePassword { get; set; }
    }
}
