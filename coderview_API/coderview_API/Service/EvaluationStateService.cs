using coderview_API.IService;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class EvaluationStateService : IEvaluationStateService
    {
        private readonly IEvaluationStateLogic _evaluationStateLogic;
        public EvaluationStateService(IEvaluationStateLogic evaluationStateLogic)
        {
            _evaluationStateLogic = evaluationStateLogic;
        }
        public List<EvaluationState> GetAllEvaluationState()
        {
            return _evaluationStateLogic.GetAllEvaluationState();
        }

        public int PostEvaluationState(EvaluationState state)
        {
            return _evaluationStateLogic.PostEvaluationState(state);
        }
    }
}
