using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.Abstract
{
    public interface ISiteService
    {
        List<Site> GetAll();
        List<Site> GetSitesByEmailId(int emailId);
        Site GetSiteBySiteId(int siteId);
        Site GetSiteBySiteName(string siteName);
        void Add(Site site);
        void Update(Site site);
        void Delete(Site site);
    }
}
