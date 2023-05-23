using ManyToManyCRUD.Domain.Models;
using ManyToManyCRUD.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentCantroller : ControllerBase
    {


        //    private EnrolmentDbContext _enrolmentDbContext;

        //    public EnrollmentCantroller(EnrolmentDbContext enrolmentDbContext)
        //    {
        //        _enrolmentDbContext = enrolmentDbContext;
        //    }

        //    [HttpGet]//api/courses
        //    public async Task<IActionResult> GetAll()
        //    {
        //        var courses = await _enrolmentDbContext.Enrollments.ToListAsync();
        //        return Ok(courses);
        //    }

        //    [HttpGet("{id}")]//api/courses/id
        //    public async Task<IActionResult> Get(int id)
        //    {
        //        var course = await _enrolmentDbContext.Enrollments.FirstOrDefaultAsync(x => x.Id == id);
        //        return Ok(course);
        //    }

        //    [HttpPost]//api/courses
        //    public async Task<IActionResult> Post([FromQuery] Enrollment model)
        //    {
        //        await _enrolmentDbContext.Enrollments.AddAsync(model);
        //        await _enrolmentDbContext.SaveChangesAsync();
        //        return Ok();

        //    }
        //    //[HttpPut]//api/courses
        //    //public async Task<IActionResult> Putget([FromQuery]int id,Course model)
        //    //{
        //    //    var oldData = await _enrolmentDbContext.Courses.FirstOrDefaultAsync(s => s.Id == id);
        //    //    await _enrolmentDbContext.SaveChangesAsync();
        //    //}


        //    //[HttpPut("{id}")]//api/courses/id
        //    //public async Task<IActionResult> Put(int id, [FromQuery] Course model)
        //    //{
        //    //    var course = await _enrolmentDbContext.Courses.FirstOrDefaultAsync(x => x.Id == id);
        //    //    // course.Id = model.Id;
        //    //    course.CoursName = model.CoursName;

        //    //    course.Description = model.Description;
        //    //    await _enrolmentDbContext.SaveChangesAsync();
        //    //    return Ok();

        //    //}

        //    [HttpDelete("{id}")]//api/courses/id
        //    public async Task<IActionResult> Delete(int id)
        //    {
        //        var course = await _enrolmentDbContext.Enrollments.FirstOrDefaultAsync(x => x.Id == id);
        //        _enrolmentDbContext.Enrollments.Remove(course);
        //        await _enrolmentDbContext.SaveChangesAsync();
        //        return Ok();

        //    }

    }
}
