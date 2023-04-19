using coderview_API.IService;
using Entities;
using Logic.ILogic;
using Microsoft.AspNetCore.Identity;

namespace coderview_API.Service
{
    public class UserRolService : IUserRolService
    {
        private readonly IUserRolLogic _userRolLogic;
        public UserRolService(IUserRolLogic userRolLogic)
        {
            _userRolLogic = userRolLogic;
        }
        public void DeactivateUserRol(int id)
        {
            _userRolLogic.DeactivateUserRol(id);
        }

        public List<UserRol> GetAllUserRol()
        {
            return _userRolLogic.GetAllUserRol();
        }

        public int PostUserRol(UserRol rol)
        {
            return _userRolLogic.PostUserRol(rol);
        }
    }
}
