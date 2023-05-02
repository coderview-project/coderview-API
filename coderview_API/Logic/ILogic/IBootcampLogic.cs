using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBootcampLogic
    {
        int AddBootcamp(BootcampItem bootcamp); 
        List<BootcampItem> GetAllBootcamp();
        void UpdateBootcamp(BootcampItem bootcamp);
        void DeactivateBootcamp(int id);
    }
}
