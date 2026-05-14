using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2.Interface
{
    public interface IAgentManager:IManager
    {
        void RegisterConsultant();
        void ViewConsultants();
    }
}
