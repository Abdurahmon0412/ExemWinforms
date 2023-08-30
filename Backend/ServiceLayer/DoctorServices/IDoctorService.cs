using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.SeeDoctors
{
    public interface IDoctorService
    {
        List<Doctor> GetAllDoctors(int clinik_id);

        Medservice GetMedservices(int doctor_id);
    }
}
