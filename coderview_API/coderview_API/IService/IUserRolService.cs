using Entities;

namespace coderview_API.IService
{
    public interface IUserRolService
    {
        List<UserRol> GetAllUserRol();
        int PostUserRol(UserRol rol);
        void DeactivateUserRol(int id);
    }
}
