
using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BootcampStudentController : ControllerBase
    {
        private readonly IBootcampStudentService _bootcampStudentService;
        public BootcampStudentController(IBootcampStudentService bootcampStudentService) 
        { 
            _bootcampStudentService= bootcampStudentService;
        }

        [HttpGet(Name = "GetAllBootcampStudent")]

        public List<BootcampStudent> GetAllBootcampStudent()
        {
            return _bootcampStudentService.GetAllBootcampStudent();
        }

        [HttpDelete(Name = "DeleteBootcampStudent")]

        public void DeleteBootcampStudent([FromQuery] int id)
        {
            _bootcampStudentService.DeleteBootcampStudent(id);
        }

        [HttpPost(Name = "PostBootcampStudent")]
        public int PostBootcampStudent([FromBody] BootcampStudent bootcampStudent)
        {
            return _bootcampStudentService.PostBootcampStudent(bootcampStudent);
        }

    }
}
