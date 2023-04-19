using Data;
using Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserRolLogic : IUserRolLogic
    {
        private readonly ServiceContext _serviceContext;
        public UserRolLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void DeactivateUserRol(int id)
        {
            try
            {
                var userRolToDeactivate = _serviceContext.Set<UserRol>().Where(u => u.Id == id).First();
                userRolToDeactivate.IsActive = false;
                _serviceContext.SaveChanges();
            }
            catch
            {
                throw new Exception("No se pudo desactivar el user rol");
            }
        }

        public List<UserRol> GetAllUserRol()
        {
            return _serviceContext.Set<UserRol>().ToList();
        }

        public int PostUserRol(UserRol rol)
        {
            try
            {
                _serviceContext.UserRols.Add(rol);
                _serviceContext.SaveChanges();
                return rol.Id;
            }
            catch
            {
                throw new Exception("Algo salió mal. No se pudo crear el user rol");
            }
        }
    }
}
