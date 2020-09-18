using MyPasswords.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Entities.Concrete
{
    public class Email : IEntity
    {
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public string EmailName { get; set; }
    }
}
