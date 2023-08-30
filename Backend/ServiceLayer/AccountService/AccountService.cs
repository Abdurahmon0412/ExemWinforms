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

        public Person Registrate(Person person)
        {
            return person;
        }

        public  Person?  SignIn(string login, string password )
        {


            var a = _context.People.FirstOrDefault(item =>
            login == item.Login
            && item.Password == password);
            return a;
        }

        public List<Clinika>? GetAllCliniks(string clinikname)
        {
            return  _context.Clinikass.ToList();
        }

        public int GetClinikId(string clinikname)
        {
            var selected = _context.Clinikass.FirstOrDefault(item => item.Fullname == clinikname);
            if(selected == null)
                return 0;
            return selected.Id;
        }
        public void AddPerson(Person person)
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public int GetPersonId(string login, string password)
        {
            var result = _context.People.FirstOrDefault(item => item.Login == login && item.Password.Equals(password));
            if (result == null)
                return 0;
            return result.Id;
        }
    }
}
