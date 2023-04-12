using Data;
using Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class EvaluationLogic : IEvaluationLogic 
    {
        private readonly ServiceContext _serviceContext;
        public EvaluationLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void DeactivateEvaluation(int id)
        {
            try
            {
                var evaluationToDeactivate = _serviceContext.Set<EvaluationItem>().Where(e => e.Id == id).First();
                evaluationToDeactivate.IsActive = false;
                _serviceContext.SaveChanges();
            } catch
            {
                throw new Exception("Algo salió mal. Su evaluación no se ha desactivado");
            }
            
        }

        public List<EvaluationItem> GetAllEvaluation()
        {
           return  _serviceContext.Set<EvaluationItem>().Where(e => e.IsActive == true).ToList();
        }

        public int GetEvaluationById(int id)
        {
            var evaluation = _serviceContext.Set<EvaluationItem>().Where(e => e.Id == id).First();
            if (evaluation != null)
            {
                return evaluation.Id;
            } else
            {
                throw new Exception("No se encontró la evaluación.");
            }
        }

        public int SubmitEvaluation(EvaluationItem evaluationItem)
        {
            try
            {
                _serviceContext.Evaluations.Add(evaluationItem);
                _serviceContext.SaveChanges();
                return evaluationItem.Id;
            } catch
            {
                throw new Exception("¡Vaya! La evaluación no ha sido registrada correctamente.");
            }
            
        }
    }
}
