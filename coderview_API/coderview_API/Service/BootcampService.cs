using coderview_API.IService;
using coderview_API.Models;
using Entities;
using Logic.ILogic;
using Logic.Logic;

namespace coderview_API.Service
{
    public class BootcampService : IBootcampService
    {
        private readonly IBootcampLogic _bootcampLogic;
        public BootcampService(IBootcampLogic bootcampLogic)
        {
            _bootcampLogic = bootcampLogic;
        }

        public void DeactivateBootcamp(int id)
        {
            _bootcampLogic.DeactivateBootcamp(id);
        }

        public List<BootcampItem> GetAllBootcamp()
        {
            return _bootcampLogic.GetAllBootcamp();
        }

        public int AddBootcamp(BootcampItem bootcamp)
        {
            if(!ValidateBootcamp(bootcamp))
            {
                throw new InvalidOperationException();
            }
            return _bootcampLogic.AddBootcamp(bootcamp);
        }

        public void UpdateBootcamp(BootcampItem bootcamp)
        {
            _bootcampLogic.UpdateBootcamp(bootcamp);
        } 
        public static bool ValidateBootcamp(BootcampItem bootcampItem)
        {

            if (bootcampItem == null)
            {
                return false;
            }
            if (bootcampItem.CreatorId > 0)
            {
                return false;
            }

            if (bootcampItem.StartDate > DateTime.Now)
            {
                return false;
            }
            if (bootcampItem.EndDate < DateTime.Now )
            {
                return false;
            }

            return true;
        }
       
    }
}
