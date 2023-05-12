using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentAPI.Models;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        Student[]? std = null;
        public StudentController()
        {
            std = new Student[] { new Student()
            {
                Name = "Alice",
                Age= 20,
                Hobbies = new List<string>(){ "reading", "swimming", "coding" }
            },
            new Student()
            {
                Name = "Bob",
                Age= 22,
                Hobbies = new List<string>(){ "painting", "dancing", "singing" }
            },
             new Student()
            {
                Name = "Chris",
                Age= 26,
                Hobbies = new List<string>(){ "singing", "running" }
            }
            };
        }
        // GET: api/<StudentController>
        [EnableCors("AllowAll")]
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return std;
        }



        //POST api/<StudentController>       
        [EnableCors("AllowAll")]
        [HttpPost("GetAllStudents")]
        public IEnumerable<Student> GetAllStudents()
        {
            return std;
        }

        // POST api/<StudentController>       
        [EnableCors("AllowAll")]
        [HttpPost("GetAllStudent")]
        public IEnumerable<Student> GetAllStudent([FromBody] string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return std.Where(s => s.Name == name);
            }

            return std;
        }
       
    }
}
