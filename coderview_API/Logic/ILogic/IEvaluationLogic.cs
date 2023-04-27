using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEvaluationLogic
    {
        int SubmitEvaluation(EvaluationItem evaluationItem);
        List<EvaluationItem> GetAllEvaluation();
        List<EvaluationItem> GetEvaluationById(int id);
        List<EvaluationItem> GetEvaluationByUserId(int id);
        List<EvaluationItem> GetAutoevaluacion();
        void DeactivateEvaluation(int id);
    }
}
