using coderview_API.Models;
using Entities;

namespace coderview_API.IService
{
    public interface IUserService
    {
        int PostUser(NewUserRequestModel newUserRequest);
        int PostInstructor(NewInstructorRequestModel newInstructorRequest);
        void UpdateUser(UserItem userItem);
        void DeactivateUser(int id);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUserById(int id);
    }
}
