using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationDataService
    {
        int SubmitEvaluation(EvaluationData data);
        List<EvaluationData> GetEvaluationData();
        List<EvaluationData> GetSelectedEvaluationData(int id);
    }
}
