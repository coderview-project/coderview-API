using coderview_API.IService;
using coderview_API.Service;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BootcampController : ControllerBase
    {
        private readonly IBootcampService _bootcampService;
        public BootcampController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpPost(Name = "PostBootcamp")]
        public int PostBootcamp([FromBody] BootcampItem bootcamp)
        {
            return _bootcampService.PostBootcamp(bootcamp);
        }

        [HttpGet(Name = "GetAllBootcamp")]

        public List<BootcampItem> GetAllBootcamp()
        {
            return _bootcampService.GetAllBootcamp();
        }

        [HttpDelete(Name = "DeactivateBootcamp")] 
        public void DeactivateBootcamp([FromQuery] int id)
        {
            _bootcampService.DeactivateBootcamp(id);
        }

        [HttpPatch(Name = "UpdateBootcamp")]

        public void UpdateBootcamp([FromBody] BootcampItem bootcamp)
        {
            _bootcampService.UpdateBootcamp(bootcamp);
        }
    }
}
