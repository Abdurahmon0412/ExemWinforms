using Backend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly EfCoreContext _context;
        public AccountService(EfCoreContext context)
        {
            _context = context;
        }
        public bool Registrate(Person person)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
