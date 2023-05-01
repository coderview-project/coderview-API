using Entities;

namespace coderview_API.IService
{
    public interface IBootcampStudentService
    {
        int AddBootcampStudent(BootcampStudent bootcampStudent);
        List<BootcampStudent> GetAllBootcampStudent();
        void DeleteBootcampStudent(int id);
    }
}
