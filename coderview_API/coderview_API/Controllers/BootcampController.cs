using coderview_API.Attributes;
using coderview_API.IService;
using coderview_API.Service;
using Entities;
using Microsoft.AspNetCore.Authorization;
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

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "PostBootcamp")]
        public int AddBootcamp([FromBody] BootcampItem bootcamp)
        {
            return _bootcampService.AddBootcamp(bootcamp);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllBootcamp")]

        public List<BootcampItem> GetAllBootcamp()
        {
            return _bootcampService.GetAllBootcamp();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name = "DeactivateBootcamp")] 
        public void DeactivateBootcamp([FromQuery] int id)
        {
            _bootcampService.DeactivateBootcamp(id);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "UpdateBootcamp")]

        public void UpdateBootcamp([FromBody] BootcampItem bootcamp)
        {
            _bootcampService.UpdateBootcamp(bootcamp);
        }
    }
}
