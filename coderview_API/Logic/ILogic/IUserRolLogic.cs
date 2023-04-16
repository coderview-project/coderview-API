using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserRolLogic
    {
        List<UserRol> GetAllUserRol();
        int PostUserRol(UserRol rol);
        void DeactivateUserRol(int id);
    }
}
