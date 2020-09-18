using FluentValidation;
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
    public class EmailManager : IEmailService
    {
        private IEmailDao _iEmailDao;
        public EmailManager(IEmailDao iEmailDao)
        {
            _iEmailDao = iEmailDao;
        }

        public List<Email> GetEmailsByUserId(int userId)
        {
            return _iEmailDao.GetAll(p => p.UserId == userId);
        }

        public Email GetEmailByEmailId(int emailId)
        {
            return _iEmailDao.Get(p => p.EmailId == emailId);
        }

        public Email GetEmailByEmailName(string emailName)
        {
            return _iEmailDao.Get(p => p.EmailName.ToLower().Contains(emailName.ToLower()));
        }
        
        public void Add(Email email)
        {
            ValidationTool.Validate(new EmailValidator(), email);
            _iEmailDao.Add(email);
        }

        public void Update(Email email)
        {
            ValidationTool.Validate(new EmailValidator(), email);
            _iEmailDao.Update(email);
        }
        
        public void Delete(Email email)
        {
            ValidationTool.Validate(new EmailValidator(), email);
            _iEmailDao.Delete(email);
        }
    }
}
