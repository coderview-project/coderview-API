using coderview_API.IService;
using Entities;
using Logic.ILogic;
using Logic.Logic;

namespace coderview_API.Service
{
    public class BootcampStudentService : IBootcampStudentService
    {
        private readonly IBootcampStudentLogic _bootcampStudentLogic; 
        public BootcampStudentService(IBootcampStudentLogic bootcampStudentLogic)
        {
            _bootcampStudentLogic = bootcampStudentLogic;
        }

        public void DeleteBootcampStudent(int id)
        {
            _bootcampStudentLogic.DeleteBootcampStudent(id);
        }

        public List<BootcampStudent> GetAllBootcampStudent()
        {
            return _bootcampStudentLogic.GetAllBootcampStudent();
        }

        public int AddBootcampStudent(BootcampStudent bootcampStudent)
        {
            return _bootcampStudentLogic.AddBootcampStudent(bootcampStudent);
        }
    }
}
