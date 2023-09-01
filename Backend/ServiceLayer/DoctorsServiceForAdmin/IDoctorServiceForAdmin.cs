using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.DoctorsServiceForAdmin
{
    public interface IDoctorServiceForAdmin
    {
        List<Doctor> GetDoctors(int medserviceId);
        string? GetMedserviceName(int medserviceId);
        void AddDoctor(Doctor doctor);
        bool DeleteDoctor(int  doctorId);
        bool EditDoctor(Doctor doctor);
    }
}
