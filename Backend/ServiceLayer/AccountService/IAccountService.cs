using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.AccountService
{
    public interface IAccountService
    {
        bool Registrate(Person person);
        bool SignIn(Person person);
    }
}
