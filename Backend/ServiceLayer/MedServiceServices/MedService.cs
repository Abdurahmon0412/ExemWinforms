using Backend.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.MedServiceServices
{
    public class MedService : IMedService
    {
        private readonly EfCoreContext _context;
        public MedService(EfCoreContext efCoreContext)
        {
            _context = efCoreContext;
        }

        public List<Medservice> GetDoctors(int medserviceId)
        {
            var medService = _context.Medservices.Include(a => a.Doctors)
                .Where(item => item.Id == medserviceId).ToList();
            return medService;
        }

        public List<Medservice> GetMedservices(int clinikId)
        {
            var medServices = _context.Medservices.Include(a => a.Doctors).Where(item => 
            item.ClinikaId == clinikId).ToList();
            return medServices;
        }

        public List<Medservice> GetMedservices()
        {
            return _context.Medservices.ToList();
        }
    }
}
