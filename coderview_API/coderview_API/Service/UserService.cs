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

        public List<UserItem> GetUserById(int id)
        {
            return _userLogic.GetUserById(id);
        }    

        public int AddInstructor(NewInstructorRequestModel newInstructorRequest)
        {
            var newInstructor = newInstructorRequest.ToUserItem();
            newInstructor.EncryptedPassword = _userSecurityLogic.HashString(newInstructorRequest.Password);
            return _userLogic.AddInstructor(newInstructor);
        }
        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }

        void IUserService.DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }

        public int AddUser(NewUserRequestModel newUserRequest)
        {
            var newUserItem = newUserRequest.ToUserItem();
            newUserItem.EncryptedPassword = _userSecurityLogic.HashString(newUserRequest.Password);
            if (!ValidateUser(newUserItem))
            {
                throw new InvalidOperationException();
            }
            if (!ValidateInsertedUser(newUserItem))
            {
                throw new InvalidOperationException();
            }
            return _userLogic.AddUser(newUserItem);
        } 
      
        public static bool ValidateUser(UserItem userItem)
        {

                if (userItem == null)
                {
                    return false;
                }
                if (userItem.UserName == null || userItem.UserName == "")
                {
                    return false;
                }
                if (userItem.LastName == null || userItem.LastName == "")
                {
                    return false;
                }               
                if (userItem.Email == null || userItem.Email == "" || userItem.Email.Length > 150)
                {
                    return false;
                }
                if (userItem.InsertDate > DateTime.Now)
                {
                    return false;
                }

                return true;
        }
        public static bool ValidateInsertedUser(UserItem userItem)
        {
            if (!ValidateUser(userItem))
            {
                return false;
            }
            if (userItem.Id < 1)
            {
                return false;
            }
            return true;
        }
           
    }              
}
            
        
    

