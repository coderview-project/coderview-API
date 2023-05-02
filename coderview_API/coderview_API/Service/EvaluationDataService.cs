using coderview_API.IService;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class EvaluationDataService : IEvaluationDataService
    {
        private readonly IEvaluationDataLogic _evaluationDataLogic;
        public EvaluationDataService(IEvaluationDataLogic evaluationDataLogic)
        {
            _evaluationDataLogic = evaluationDataLogic;
        }
        public int SubmitEvaluation(EvaluationData data)
        {
            return _evaluationDataLogic.SubmitEvaluation(data);
        }

        public List<EvaluationData> GetEvaluationData()
        {
            return _evaluationDataLogic.GetEvaluationData();
        }

        public List<EvaluationData> GetSelectedEvaluationData(int id)
        {
            return _evaluationDataLogic.GetSelectedEvaluationData(id);
        }
    }
}
