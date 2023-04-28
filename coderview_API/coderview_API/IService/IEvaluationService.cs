using coderview_API.Attributes;
using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationService
    {
        //int SubmitEvaluation(EvaluationItem evaluationItem);
        List<EvaluationItem> GetAllEvaluation();
        List<EvaluationItem> GetEvaluationById(int id);
        List<EvaluationItem> GetEvaluationByUserId(int id);
        List<EvaluationItem> GetAutoevaluacion();
        void DeactivateEvaluation(int id);
    }
}
