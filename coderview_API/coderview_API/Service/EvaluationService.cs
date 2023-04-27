using coderview_API.IService;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class EvaluationService : IEvaluationService
    {
        private readonly IEvaluationLogic _evaluationLogic;
        public EvaluationService(IEvaluationLogic evaluationLogic)
        {
           _evaluationLogic = evaluationLogic;
        }

        public void DeactivateEvaluation(int id)
        {
             _evaluationLogic.DeactivateEvaluation(id);
        }

        public List<EvaluationItem> GetAllEvaluation()
        {
            return _evaluationLogic.GetAllEvaluation();
        }

        public List<EvaluationItem> GetEvaluationById(int id)
        {
            return _evaluationLogic.GetEvaluationById(id);
        }

        public List<EvaluationItem> GetEvaluationByUserId(int id)
        {
            return _evaluationLogic.GetEvaluationByUserId(id);
        }

        public List<EvaluationItem> GetAutoevaluacion()
        {
            return _evaluationLogic.GetAutoevaluacion();
         }

        public int SubmitEvaluation(EvaluationItem evaluationItem)
        {
            return _evaluationLogic.SubmitEvaluation(evaluationItem);
        }

        
    }
}
