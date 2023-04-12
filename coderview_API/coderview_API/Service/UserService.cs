using coderview_API.IService;
using coderview_API.Models;
using Data;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;   
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        int IUserService.PostUser(UserItem userItem)
        {
            _userLogic.PostUser(userItem);
            return userItem.Id;
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
