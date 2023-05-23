using ManyToManyCRUD.Domain.Models;
using ManyToManyCRUD.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManyToManyCRUD.Domain.DTO;
using System.Linq;

namespace ManyToManyCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private EnrolmentDbContext _enrolmentDbContext;

        public StudentsController(EnrolmentDbContext enrolmentDbContext)
        {
            _enrolmentDbContext = enrolmentDbContext;
        }

        [HttpGet]//api/students
        public async Task<IActionResult> GetAll()
        {
            var students = await _enrolmentDbContext.Students.Include(x => x.Enrollments).
                ThenInclude(a => a.Course).ToListAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]//api/courses/id
        public async Task<IActionResult> Get(int id)
        {
            var student = await _enrolmentDbContext.Students.
                Include(x => x.Enrollments).
                ThenInclude(a => a.Course).
                FirstOrDefaultAsync(x => x.Id == id);
            return Ok(student);
        }

        //[HttpPost]//api/courses
        //public async Task<IActionResult> Post([FromQuery] EnrollmentDTO modelDTO)
        //{
        //    var student = new Student()
        //    {
        //        StudentName = modelDTO.Name
        //    };
        //    foreach (var item in modelDTO.CourseId)
        //    {
        //        student.Enrollments.Add(new Enrollment()
        //        {
        //           Student=student,
        //           Id=item
        //        });
        //    }
        //    _enrolmentDbContext.Students.Add(student);
        //    _enrolmentDbContext.SaveChanges();
        //    return Ok();

        //}
        [HttpPost]//api/courses
        public async Task<IActionResult> Post([FromQuery] Student model)
        {
            await _enrolmentDbContext.Students.AddAsync(model);
            await _enrolmentDbContext.SaveChangesAsync();
            return Ok();

        }

        //[HttpPut("{id}")]//api/courses/id
        //public async Task<IActionResult> Put(int id, [FromQuery] Student model)
        //{ 
        //    var student = await _enrolmentDbContext.Students.
        //        Include(x=>x.Enrollments).
        //        ThenInclude(y=>y.Course).
        //        FirstOrDefaultAsync(x => x.Id == id);
        //    //student.StudentName = modelDTO.Name;
        //    var existingId = student.Enrollments.Select(x => x.Id).ToList();
        //    //var selectedId = modelDTO.CourseId.ToList();
        //    var toAdd = selectedId.Except(existingId).ToList();
        //    var toRemove = existingId.Except(selectedId).ToList();
        //    student.Enrollments = student.Enrollments.Where(x => !toRemove.Contains(x.Id)).ToList();
        //    foreach (var item in toAdd)
        //    {
        //        student.Enrollments.Add(new Enrollment()
        //        {
        //            Id = item
        //        });
        //    }
        //    _enrolmentDbContext.Students.Update(student);
        //    await _enrolmentDbContext.SaveChangesAsync();
        //    return Ok();

        //}
        [HttpPut("{id}")]//api/courses/id
        public async Task<IActionResult> Put(int id, [FromQuery] Student model)
        {
            var student = await _enrolmentDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            student.Id = model.Id;
            student.StudentName = model.StudentName;
            student.Email = model.Email;
            await _enrolmentDbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id}")]//api/courses/id
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _enrolmentDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            _enrolmentDbContext.Students.Remove(student);
            await _enrolmentDbContext.SaveChangesAsync();
            return Ok();

        }
    }
}
