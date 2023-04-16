using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEvaluationStateLogic
    {
        List<EvaluationState> GetAllEvaluationState();
        int PostEvaluationState(EvaluationState state);
    }
}
