using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepoUnitOfWork.Intarfaces;
using RepoUnitOfWork.Models;
using System.Threading.Tasks;

namespace RepoUnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //private ApplicationDbContext _applicationDbContext;
        private IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]//api/students
        public async Task<IActionResult> GetAll()
        {
            await _unitOfWork.studentRepo.ToListAsync();
            
            return Ok();
        }

        [HttpPost]//api/courses
        public async Task<IActionResult> Post([FromQuery] Student model)
        {
            await _unitOfWork.studentRepo.AddAsync(model);
            await _unitOfWork.SaveChangesAsync();
            return Ok();

        }
        [HttpPut("{id}")]//api/courses/id
        public async Task<IActionResult> Put(int id, [FromQuery] Student model)
        {
            var student = await _unitOfWork.studentRepo.FirstOrDefaultAsync();
            //student.Id = model.Id;
            student.StudentName = model.StudentName;
            student.Email = model.Email;
            student.CourseId = model.CourseId;
            await _unitOfWork.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id}")]//api/courses/id
        public async Task<IActionResult> Delete()
        {
            
            _unitOfWork.studentRepo.Remove();
            await _unitOfWork.SaveChangesAsync();
            return Ok();

        }
    }
}
