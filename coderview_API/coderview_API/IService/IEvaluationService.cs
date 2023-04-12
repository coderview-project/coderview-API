using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationService
    {
        int SubmitEvaluation(EvaluationItem evaluationItem);
        List<EvaluationItem> GetAllEvaluation();
        int GetEvaluationById(int id);
        void DeactivateEvaluation(int id);
    }
}
