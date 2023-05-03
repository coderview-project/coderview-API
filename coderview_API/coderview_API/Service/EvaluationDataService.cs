using coderview_API.IService;
using coderview_API.Models;
using Entities;
using Logic.ILogic;
using Logic.Logic;

namespace coderview_API.Service
{
    public class EvaluationDataService : IEvaluationDataService
    {
        private readonly IEvaluationDataLogic _evaluationDataLogic;
        public EvaluationDataService(IEvaluationDataLogic evaluationDataLogic)
        {
            _evaluationDataLogic = evaluationDataLogic;
        } 
        public List<EvaluationData> GetEvaluationData()
        {
            return _evaluationDataLogic.GetEvaluationData();
        }
        public List<EvaluationData> GetSelectedEvaluationData(int id)
        {
            return _evaluationDataLogic.GetSelectedEvaluationData(id);
        }
        public int SubmitEvaluation(EvaluationData data)
        {           
            if (ValidateEvaluetionData(data))
            {
                return _evaluationDataLogic.SubmitEvaluation(data);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static bool ValidateEvaluetionData( EvaluationData evaluationData)
        {

            if (evaluationData == null)
            {
                return false;
            }           
          
            if (evaluationData.ProjectM < 1)
            {
                return false;
            }
            if (evaluationData.FuncTech1 < 1)
            {
                return false;
            }
            if (evaluationData.FuncTech2 < 1)
            {
                return false;
            }
            if (evaluationData.FuncTech3 < 1)
            {
                return false;
            }
            if (evaluationData.Front1 <1)
            {
                return false;
            }
            if (evaluationData.Front2 < 1)
            {
                return false;
            }
            if (evaluationData.Back1 < 1)
            {
                return false;
            }
            if (evaluationData.Back2 < 1)
            {
                return false;
            }
            if (evaluationData.Archit < 1)
            {
                return false;
            }
            if (evaluationData.Qa1 < 1)
            {
                return false;
            }
            if (evaluationData.Qa2 < 1)
            {
                return false;
            }
            if (evaluationData.Qa3 < 1)
            {
                return false;
            }
            if (evaluationData.EvaluatorId < 1)
            {
                return false;
            }
            if (evaluationData.EvaluateeId < 1)
            {
                return false;
            }
            if (evaluationData.EvaluationId < 1)
            {
                return false;
            }
            return true;
        }               
    }
}
