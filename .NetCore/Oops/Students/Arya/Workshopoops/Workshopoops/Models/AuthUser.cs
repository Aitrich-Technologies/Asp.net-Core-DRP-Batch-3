using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshopoops.Enum;

namespace Workshopoops.Models
{
    public class AuthUser
    {
        public int userid {  get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public UserRoles Role {  get; set; }

    }
}
