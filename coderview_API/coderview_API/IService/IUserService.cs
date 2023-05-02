using coderview_API.Models;
using Entities;

namespace coderview_API.IService
{
    public interface IUserService
    {
        int AddUser(NewUserRequestModel newUserRequest);
        int AddInstructor(NewInstructorRequestModel newInstructorRequest);
        void UpdateUser(UserItem userItem);
        void DeactivateUser(int id);
        List<UserItem> GetAllUsers();
        List<UserItem> GetUserById(int id);
    }
}
