using coderview_API.Attributes;
using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserRolController
    {
        private readonly IUserRolService _userRolService;
        public UserRolController(IUserRolService userRolService)
        {
            _userRolService = userRolService;
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpGet(Name = "GetAllUserRol")]
        public List<UserRol> GetAllUserRol()
        {
            return _userRolService.GetAllUserRol();
        }

        //[EndpointAuthorize(AllowedUserRols = "Administrador")]
        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "PostUserRol")]
        public int AddUserRol(UserRol rol)
        {
            return _userRolService.AddUserRol(rol);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeactivateUserRol")]
        public void DeactivateUserRol([FromQuery] int id)
        {
            _userRolService.DeactivateUserRol(id);
        }
    }
}
