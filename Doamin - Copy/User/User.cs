using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Domain.Attributes;

namespace Domain.User
{
    [Auditable]
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public string Role { get; set; }
    }
}
