using System.Collections.Generic;
using System.Threading.Tasks;
using DoctorsApp.Models;

namespace DoctorsApp.Core
{
    public interface IDoctorRepository
    {
         IEnumerable<DoctorSummary> GetDoctors();
         Task<DoctorDetail> GetDoctor(int id);
    }
}