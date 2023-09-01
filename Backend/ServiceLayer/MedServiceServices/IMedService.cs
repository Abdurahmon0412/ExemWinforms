using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.MedServiceServices
{
    public interface IMedService
    {
        List<Medservice> GetMedservices(int clinikId);
        List<Medservice> GetMedservices();
        List<Doctor> GetDoctors(int  medserviceId);
        string GetMedserviceName(int medserviceId);
        bool DeleteDoctor(int doctorId);
    }
}
