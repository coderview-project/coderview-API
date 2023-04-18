using coderview_API.Models;
using Entities;

namespace coderview_API.IService
{
    public interface IUserService
    {
        int PostUser(NewUserRequestModel newUserRequest);
        void UpdateUser(UserItem userItem);
        void DeactivateUser(int id);
        List<UserItem> GetAllUsers();
    }
}
