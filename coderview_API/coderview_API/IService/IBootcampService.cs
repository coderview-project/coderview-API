using Entities;

namespace coderview_API.IService
{
    public interface IBootcampService
    {
        int PostBootcamp(BootcampItem bootcamp);
        List<BootcampItem> GetAllBootcamp();
        void UpdateBootcamp(BootcampItem bootcamp);
        void DeactivateBootcamp(int id);
    }
}
