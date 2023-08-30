using Backend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.ClinikManagmetService
{
    public class ClinikManagement : ICLinikManagement
    {
        private readonly EfCoreContext _context;
        public ClinikManagement(EfCoreContext context)
        {
            _context = context;
        }

        public List<Clinika> GetClinikas()
        {
                 return _context.Clinikass.ToList();
        }

        public bool EditClinikas(Clinika clinika)
        {
            var result =  _context.Clinikass.FirstOrDefault(a => a.Id == clinika.Id);
            if(result == null)
            {
                return false;
            }
            _context.Clinikass.Remove(result);
            _context.Clinikass.Add(clinika);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteClinikas(int id)
        {
            var result = _context.Clinikass.FirstOrDefault(item => item.Id == id);
            if( result == null )
                return false;
            else
            {
               // var people = _context.People.Where(p => p.ClinikaId == result.Id);
                //_context.RemoveRange(people);
                _context.Clinikass.Remove(result);
                _context.SaveChanges();
                return true;
            }

        }

        public bool AddClinikas(Clinika clinika)
        {
            try
            {
                _context.Clinikass.Add(clinika);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
