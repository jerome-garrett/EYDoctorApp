using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorsApp.Core;
using DoctorsApp.Data;
using DoctorsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorsApp.Persistence
{
     public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext context;
        public DoctorRepository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<DoctorSummary> GetDoctors()
        {
            return context.Doctors
                .Select(x => new DoctorSummary{
                    Id = x.Id,
                    Name = x.Name,
                    Gender = x.Gender,
                    Specialties = x.DoctorSpecialties.Select(s => s.Specialty.Name),
                    Average = x.PatientRatings.Select(r => r.Rating).Average()
                });
        }

        public async Task<DoctorDetail> GetDoctor(int id)
        {
            return await context.Doctors.Where(x => x.Id == id).Select(x => new DoctorDetail {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                MedicalSchool = x.MedicalSchool.Name,
                Languages = x.DoctorLanguages.Select(c => c.Language.Name),
                Specialties = x.DoctorSpecialties.Select(s => s.Specialty.Name),
                PatientRatings = x.PatientRatings,
                Average = x.PatientRatings.Select( c => c.Rating).Average()
            }).SingleOrDefaultAsync();
        }
    }
}