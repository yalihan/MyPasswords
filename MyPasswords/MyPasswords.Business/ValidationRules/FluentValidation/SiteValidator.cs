using FluentValidation;
using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.ValidationRules.FluentValidation
{
    public class SiteValidator : AbstractValidator<Site>
    {
        public SiteValidator()
        {
            RuleFor(p => p.EmailId).NotEmpty();
            RuleFor(p => p.SiteName).Must(ContainingDot).WithMessage("Gecerli bir site adi giriniz !");
            RuleFor(p => p.SiteUserName).NotEmpty().WithMessage("Lutfen bir kullanici adi belirleyiniz !");
            RuleFor(p => p.SitePassword).NotEmpty().WithMessage("Lutfen bir sifre belirleyiniz !");
        }
        private bool ContainingDot(string arg)
        {
            return arg.Contains(".");
        }
    }
}
