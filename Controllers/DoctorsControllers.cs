using System.Threading.Tasks;
using DoctorsApp.Core;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepository repo;
        public DoctorsController(IDoctorRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            var doctors = repo.GetDoctors();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            var doctor = await repo.GetDoctor(id);
            return Ok(doctor);
        }

    }
}