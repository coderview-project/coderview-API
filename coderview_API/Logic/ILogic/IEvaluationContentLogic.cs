using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEvaluationContentLogic
    {
        int AddEvaluationContent(EvaluationContent econtent);
        List<EvaluationContent> GetAllEvaluationContent();
        void DeleteEvaluationContent(int id); 
    }
}
