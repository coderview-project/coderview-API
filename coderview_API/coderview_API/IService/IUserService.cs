using Entities;

namespace coderview_API.IService
{
    public interface IUserService
    {
        int PostUser(UserItem userItem);
        void UpdateUser(UserItem userItem);
        void DeactivateUser(int id);
        List<UserItem> GetAllUsers();
    }
}
