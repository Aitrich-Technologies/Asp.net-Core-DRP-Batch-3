using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshopoops.Models;

namespace Workshopoops.Interface
{
    public interface IUserRepositary
    {
        void Register(AuthUser user);
        AuthUser Login(string username, string password);
    }
}
