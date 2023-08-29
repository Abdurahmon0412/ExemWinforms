using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.AccountService
{
    public interface IAccountService
    {
        Person Registrate(Person person);
        Person? SignIn(string login,string password);
        List<Clinika> GetAllCliniks(string clinikname);
        int GetClinikId(string clinikname);
        void AddPerson(Person person);

    }
}
