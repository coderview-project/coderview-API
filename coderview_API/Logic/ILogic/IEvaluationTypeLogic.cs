using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IEvaluationTypeLogic
    {
        List<EvaluationType> GetAllEvaluationType();
        int PostEvaluationType(EvaluationType type);
    }
}
