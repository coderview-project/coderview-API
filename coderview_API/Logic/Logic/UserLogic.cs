using Data;
using Entities;
using Entities.Enums;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly ServiceContext _serviceContext;

        public UserLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;

        }

        public List<UserItem> GetAllUsers()
        {
            return _serviceContext.Set<UserItem>()
                .Where(u => u.IsActive == true)
                .ToList();
        }

        public int PostUser(UserItem userItem)
        {
            if (!_serviceContext.Users.Any(u => u.Email == u.Email))
            {
                if (userItem.UserRolId == (int)UserEnums.Administrador)
                {
                    throw new InvalidOperationException();
                };

                userItem.EncryptedToken = "NOT GENERATED";

                _serviceContext.Users.Add(userItem);
                _serviceContext.SaveChanges();
            }
            return userItem.Id;
        }

        public int PostInstructor(UserItem userItem)
        {
            if (userItem.UserRolId == (int)UserEnums.Administrador)
            {
                throw new InvalidOperationException();
            };

            userItem.EncryptedToken = "NOT GENERATED";

            _serviceContext.Users.Add(userItem);
            _serviceContext.SaveChanges();

            return userItem.Id;
        }

        public void UpdateUser(UserItem userItem)
        {
            _serviceContext.Users.Update(userItem);
            _serviceContext.SaveChanges();
        }
        public void DeactivateUser(int id)
        {
            var userToDeactivate = _serviceContext.Set<UserItem>()
           .Where(i => i.Id == id).First();

            userToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }
    }
}
