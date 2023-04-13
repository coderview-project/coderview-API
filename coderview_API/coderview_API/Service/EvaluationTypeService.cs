using coderview_API.IService;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class EvaluationTypeService : IEvaluationTypeService
    {
        private readonly IEvaluationTypeLogic _evaluationTypeLogic;
        public EvaluationTypeService(IEvaluationTypeLogic evaluationTypeLogic)
        {
            _evaluationTypeLogic = evaluationTypeLogic;
        }

        public List<EvaluationType> GetAllEvaluationType()
        {
            return _evaluationTypeLogic.GetAllEvaluationType();
        }

        public int PostEvaluationType(EvaluationType type)
        {
           return _evaluationTypeLogic.PostEvaluationType(type);
        }
    }
}
