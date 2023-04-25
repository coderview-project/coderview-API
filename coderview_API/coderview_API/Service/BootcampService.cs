using coderview_API.IService;
using Entities;
using Logic.ILogic;

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

        public int PostBootcamp(BootcampItem bootcamp)
        {
            return _bootcampLogic.PostBootcamp(bootcamp);
        }

        public void UpdateBootcamp(BootcampItem bootcamp)
        {
            _bootcampLogic.UpdateBootcamp(bootcamp);
        }
    }
}
