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

        //Original 

        public int PostUser(NewUserRequestModel newUserRequest)
        {
           var newUserItem = newUserRequest.ToUserItem();
            newUserItem.EncryptedPassword = _userSecurityLogic.HashString(newUserRequest.Password);
            return _userLogic.PostUser(newUserItem);
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }

        void IUserService.DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }

        //// Ejemplo Marco 

        
        //public int PostUser(NewUserRequestModel newUserRequest)
        //{
        //    if (ValidateNewUser(newUserRequest))
        //    { 
        //    var newUserItem = newUserRequest.ToUserItem();
        //    newUserItem.EncryptedPassword = _userSecurityLogic.HashString(newUserRequest.Password);
        //    return _userLogic.PostUser(newUserItem);
        //    }
        //    else
        //    {
        //        throw new InvalidDataException();
        //    }
        //}
        //public int ValidateNewUser(UserItem userItem) 
        //{

          
        //    if(userItem == null) 
        //    {
        //        return false;
        //    }
        //    if (userItem.UserName == null || userItem.UserName =="") 
        //    {
        //       return false;
        //    }
        //    if (userItem.LastName== null || userItem.LastName == "")
        //    {
        //       return false;
        //    }
        //    if (userItem.LastName == null || userItem.LastName == "")
        //    {
        //        return false;
        //    }
        //    if (userItem.Email == null || userItem.Email == "")
        //    {
        //       return false;
        //    }
        //    if (userItem.InsertDate > DateTime.Now)
        //    {
        //        return false;
        //    }
        //    if (userItem.UpdateDate != null)
        //    {
        //        return false;


                
        //    return true;
                
            
        //}
    }
    
}
