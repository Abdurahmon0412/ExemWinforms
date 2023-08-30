using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ServiceLayer.ClinikManagmetService
{
    public interface ICLinikManagement
    {
        List<Clinika> GetClinikas();
        bool EditClinikas(Clinika clinika);
        bool DeleteClinikas(int id);
        bool AddClinikas(Clinika clinika);
    }
}
