using FluentValidation;
using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Business.ValidationRules.FluentValidation
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.EmailName).Must(ContainsAnAt).WithMessage("Girdiginiz veri, email tipinde degil ! ");
        }
        private bool ContainsAnAt(string arg)
        {
            return arg.Contains("@");
        }
    }
}
