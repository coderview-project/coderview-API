using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEvaluationDataLogic
    {
        int SubmitEvaluation(EvaluationData data);
        List<EvaluationData> GetEvaluationData();
        List<EvaluationData> GetSelectedEvaluationData(int id);
    }
}
