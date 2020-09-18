using FluentValidation;
using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Lütfen Bir Kullanici Adi Giriniz !");
            RuleFor(p => p.UserPassword).NotEmpty().WithMessage("Lütfen Bir Sifre Giriniz !");
        }
    }
}
