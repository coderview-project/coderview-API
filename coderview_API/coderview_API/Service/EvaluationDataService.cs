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

        // Creamos una nueva clase y Validamos elementos de la clase EvaluationData 
        public int SubmitEvaluationData(EvaluationData data)
        {
                      
            if (!ValidateEvaluetionData(data))
            {
                throw new InvalidDataException();
            }
           
            if (!ValidateInsertEvaluationData(data))
            {
                throw new InvalidOperationException();
            }
            return _evaluationDataLogic.SubmitEvaluation(data);

        }

        // Creamos una nueva clase y Validamos elementos de la clase EvaluationData 
        public static bool ValidateEvaluetionData( EvaluationData data)
        {

            if (data == null)
            {
                return false;
            }
            if (data.Id < 1)
            {
                return false;
            } 
            if (data.ProjectM < 1)
            {
                return false;
            }
            if (data.FuncTech1 < 1)
            {
                return false;
            }
            if (data.FuncTech2 < 1)
            {
                return false;
            }
            if (data.FuncTech3 < 1)
            {
                return false;
            }
            if (data.Front1 <1)
            {
                return false;
            }
            if (data.Front2 < 1)
            {
                return false;
            }
            if (data.Back1 < 1)
            {
                return false;
            }
            if (data.Back2 < 1)
            {
                return false;
            }
            if (data.Archit < 1)
            {
                return false;
            }
            if (data.Qa1 < 1)
            {
                return false;
            }
            if (data.Qa2 < 1)
            {
                return false;
            }
            if (data.Qa3 < 1)
            {
                return false;
            }
            if (data.EvaluatorId < 1)
            {
                return false;
            }
            if (data.EvaluateeId < 1)
            {
                return false;
            }
            if (data.EvaluationId < 1)
            {
                return false;
            }

            return true;
        }
        public static bool ValidateInsertEvaluationData(EvaluationData data)
        {
            if (!ValidateEvaluetionData(data))
            {
                return false;
            }
            if (data.Id < 1)
            {
                return false;
            }
            return true;
        }
    }
}
