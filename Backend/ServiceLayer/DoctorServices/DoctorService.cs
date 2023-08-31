using Backend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.SeeDoctors
{
    public class DoctorService:IDoctorService
    {
        private readonly EfCoreContext _context;
        public DoctorService(EfCoreContext context)
        {
            _context = context;
        }
        public List<Doctor> GetAllDoctors(int clinik_id)
        {
            var a = new  List<Doctor>();
            return a;
        }

        public Medservice? GetMedservices(int doctor_id)
        {
            var findDoctor = _context.Doctors.FirstOrDefault(item => item.Id == doctor_id);
            var medservices = _context.Medservices.FirstOrDefault(item => item.Id == findDoctor.MedserviceId);
            if (medservices == null)
                return null;
            return medservices;
        }
    }
}
