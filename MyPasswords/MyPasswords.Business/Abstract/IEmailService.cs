using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.Abstract
{
    public interface IEmailService
    {
        List<Email> GetEmailsByUserId(int userId);
        Email GetEmailByEmailId(int emailId);
        Email GetEmailByEmailName(string emailName);
        void Add(Email email);
        void Update(Email email);
        void Delete(Email email);
    }
}
