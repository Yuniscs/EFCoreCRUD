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
    public class CourseController : ControllerBase
    {
        //private ApplicationDbContext _context;
        private IUnitOfWork _unitOfWork;
        
        public CourseController(ApplicationDbContext context,IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]//api/courses
        public async Task<IActionResult> GetAll()
        {
            await _unitOfWork.courseRepo.ToListAsync();
            return Ok();
        }



        [HttpPost]//api/courses
        public async Task<IActionResult> Post([FromQuery] Course model)
        {
            _unitOfWork.courseRepo.Add(model);
            _unitOfWork.SaveChanges();
            //await _context.Courses.AddAsync(model);
            //await _context.SaveChangesAsync();
            return Ok();

        }


        [HttpPut("{id}")]//api/courses/id
        public async Task<IActionResult> Put(int id, [FromQuery] Course model)
        {
            var course = await _unitOfWork.courseRepo.FirstOrDefaultAsync(x => x.Id == id);
            // course.Id = model.Id;
            course.CoursName = model.CoursName;

            course.Description = model.Description;
            _unitOfWork.SaveChanges();
            return Ok();

        }

        [HttpDelete("{id}")]//api/courses/id
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _unitOfWork.courseRepo.FirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.courseRepo.Remove(course);
            await _unitOfWork.SaveChangesAsync();
            return Ok();
        }
    }
}
