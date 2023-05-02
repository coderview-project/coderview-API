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
    public class BootcampStudentLogic : IBootcampStudentLogic
    {
        private readonly ServiceContext _serviceContext; 
        public BootcampStudentLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void DeleteBootcampStudent(int id)
        {
            _serviceContext.BootCampStudents.Remove(_serviceContext.Set<BootcampStudent>().Where(bs => bs.Id == id).First());
            _serviceContext.SaveChanges();
        }

        public List<BootcampStudent> GetAllBootcampStudent()
        {
            return _serviceContext.Set<BootcampStudent>().ToList();
        }

        public int AddBootcampStudent(BootcampStudent bootcampStudent)
        {
            _serviceContext.BootCampStudents.Add(bootcampStudent);
            _serviceContext.SaveChanges();
            return bootcampStudent.Id;
        }
    }
}
