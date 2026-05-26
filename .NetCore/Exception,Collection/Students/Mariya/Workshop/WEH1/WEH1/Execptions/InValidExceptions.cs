using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace WEH1.Execptions
{
    internal class InValidExceptions:Exception
    {
        public InValidExceptions(string message) : base(message) { }
    }
}
