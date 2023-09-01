using Backend.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.DoctorsServiceForAdmin
{
    public class DoctorServiceForAdmin : IDoctorServiceForAdmin
    {
        private readonly EfCoreContext _context;
        public DoctorServiceForAdmin(EfCoreContext context)
        {
            _context = context;
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
        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public bool DeleteDoctor(int doctorId)
        {
            var result = _context.Clinikass.FirstOrDefault(item => item.Id == doctorId);
            if (result == null)
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

        public bool EditDoctor(Doctor doctor)
        {
            var updateDoctor = _context.Doctors.FirstOrDefault(a => a.Id == doctor.Id);
            if (updateDoctor != null)
            {
                updateDoctor.FloorPlace = doctor.FloorPlace;
                updateDoctor.RoomPlace = doctor.RoomPlace;
                updateDoctor.EndTime = doctor.EndTime;
                updateDoctor.StartTime = doctor.StartTime;
                updateDoctor.Experience = doctor.Experience;
                _context.SaveChanges(true);
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}
