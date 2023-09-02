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

        public List<Doctor> GetDoctors(int medserviceId)
        {
            var medService = _context.Doctors.Where(item => item.MedserviceId == medserviceId).ToList();
            return medService;
        }

        public string? GetMedserviceName(int medserviceId)
        {
            return _context.Medservices.Where(item => item.Id == medserviceId)
                .Select(item => item.MedserviceName).ToString();
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

        public bool DeleteDoctor(int doctorId)
        {
                var result = _context.Doctors.FirstOrDefault(item => item.Id == doctorId);
                if (result == null)
                    return false;
                else
                {
                    // var people = _context.People.Where(p => p.ClinikaId == result.Id);
                    //_context.RemoveRange(people);
                    _context.Doctors.Remove(result);
                    _context.SaveChanges();
                    return true;
                }
        }

        public bool DeleteMedservice(int personId, int medServiceId)
        {
            var person = _context.People.FirstOrDefault(per =>  per.Id == personId);
            var result = _context.Medservices.FirstOrDefault(med =>
            med.Id == medServiceId);// && med.ClinikaId == person.ClinikaId);
            if (result == null) return false;
            _context.Medservices.Remove(result);
            _context.SaveChanges();
            return true;
        }

        public bool EditMedServie(Medservice medService)
        {
            var updateMedService = _context.Medservices.FirstOrDefault(med => med.Id == medService.Id);
                if (updateMedService != null)
                {
                    updateMedService.ServicePrice = medService.ServicePrice;
                    _context.SaveChanges(true);
                    return true;
                }
                return false;
        }

        public bool AddMedservice(Medservice medservice)
        {
            try
            {
                _context.Medservices.Add(medservice);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
    }
}
