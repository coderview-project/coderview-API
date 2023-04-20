using coderview_API.IService;
using coderview_API.Models;
using Data;
using Entities;
using Logic.ILogic;
using Logic.Logic;

namespace coderview_API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        private readonly IUserSecurityLogic _userSecurityLogic;
        
        public UserService(IUserLogic userLogic, IUserSecurityLogic userSecurityLogic)
        {
            _userLogic = userLogic;   
            _userSecurityLogic = userSecurityLogic;
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public int PostUser(NewUserRequestModel newUserRequest)
        {
            var newUserItem = newUserRequest.ToUserItem();
            newUserItem.EncryptedPassword = _userSecurityLogic.HashString(newUserRequest.Password);
            return _userLogic.PostUser(newUserItem);
        }

        public int PostInstructor(NewInstructorRequestModel newInstructorRequest)
        {
            var newInstructor = newInstructorRequest.ToUserItem();
            newInstructor.EncryptedPassword = _userSecurityLogic.HashString(newInstructorRequest.Password);
            return _userLogic.PostInstructor(newInstructor);
        }
        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }

        void IUserService.DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }
    }
}
