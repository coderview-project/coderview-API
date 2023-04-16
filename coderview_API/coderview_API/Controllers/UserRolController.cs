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

        [HttpGet(Name = "GetAllUserRol")]

        public List<UserRol> GetAllUserRol()
        {
            return _userRolService.GetAllUserRol();
        }

        [HttpPost(Name = "PostUserRol")]

        public int PostUserRol(UserRol rol)
        {
            return _userRolService.PostUserRol(rol);
        }

        [HttpDelete(Name = "DeactivateUserRol")]
        public void DeactivateUserRol(int id)
        {
            _userRolService.DeactivateUserRol(id); 
        }
    }
}
