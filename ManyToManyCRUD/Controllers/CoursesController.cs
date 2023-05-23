using ManyToManyCRUD.Domain;
using ManyToManyCRUD.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private EnrolmentDbContext _enrolmentDbContext;

        public CoursesController(EnrolmentDbContext enrolmentDbContext)
        {
            _enrolmentDbContext = enrolmentDbContext;
        }

        [HttpGet]//api/courses
        public async Task<IActionResult> GetAll()
        {
            var courses = await _enrolmentDbContext.Courses.ToListAsync();
            return Ok(courses);
        }

        [HttpGet("{id}")]//api/courses/id
        public async Task<IActionResult> Get(int id)
        {
            var course = await _enrolmentDbContext.Courses.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(course);
        }

        [HttpPost]//api/courses
        public async Task<IActionResult> Post([FromQuery] Course model)
        {
            await _enrolmentDbContext.Courses.AddAsync(model);
            await _enrolmentDbContext.SaveChangesAsync();
            return Ok();

        }
        //[HttpPut]//api/courses
        //public async Task<IActionResult> Putget([FromQuery]int id,Course model)
        //{
        //    var oldData = await _enrolmentDbContext.Courses.FirstOrDefaultAsync(s => s.Id == id);
        //    await _enrolmentDbContext.SaveChangesAsync();
        //}


        [HttpPut("{id}")]//api/courses/id
        public async Task<IActionResult> Put(int id, [FromQuery] Course model)
        {
            var course = await _enrolmentDbContext.Courses.FirstOrDefaultAsync(x => x.Id == id);
           // course.Id = model.Id;
            course.CoursName = model.CoursName;
           
            course.Description = model.Description;
            await _enrolmentDbContext.SaveChangesAsync();
            return Ok();

        }

        [HttpDelete("{id}")]//api/courses/id
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _enrolmentDbContext.Courses.FirstOrDefaultAsync(x => x.Id == id);
            _enrolmentDbContext.Courses.Remove(course);
            await _enrolmentDbContext.SaveChangesAsync();
            return Ok();

        }
    }
}
