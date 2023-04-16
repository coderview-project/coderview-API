using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationStateService
    {
        List<EvaluationState> GetAllEvaluationState();
        int PostEvaluationState(EvaluationState state);
    }
}
