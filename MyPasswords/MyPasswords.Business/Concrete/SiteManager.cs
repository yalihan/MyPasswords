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
    public class SiteManager : ISiteService
    {
        private ISiteDao _iSiteDao;
        public SiteManager(ISiteDao iSiteDao)
        {
            _iSiteDao = iSiteDao;
        }

        public List<Site> GetAll()
        {
            return _iSiteDao.GetAll();
        }
        public List<Site> GetSitesByEmailId(int emailId)
        {
            if (emailId != null)
                return _iSiteDao.GetAll(p => p.EmailId == emailId);
            else
                return _iSiteDao.GetAll();
        }

        public Site GetSiteBySiteId(int siteId)
        {
            return _iSiteDao.Get(p => p.SiteId == siteId);
        }

        public Site GetSiteBySiteName(string siteName)
        {
            return _iSiteDao.Get(p => p.SiteName.ToLower().Contains(siteName.ToLower()));
        }

        public void Add(Site site)
        {
            ValidationTool.Validate(new SiteValidator(), site);
            _iSiteDao.Add(site);
        }

        public void Update(Site site)
        {
            ValidationTool.Validate(new SiteValidator(), site);
            _iSiteDao.Update(site);
        }

        public void Delete(Site site)
        {
            ValidationTool.Validate(new SiteValidator(), site);
            _iSiteDao.Delete(site);
        }


    }
}
