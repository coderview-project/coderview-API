using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBootcampStudentLogic
    {
        int PostBootcampStudent(BootcampStudent bootcampStudent);
        List<BootcampStudent> GetAllBootcampStudent();
        void DeleteBootcampStudent(int id);
    }
}
