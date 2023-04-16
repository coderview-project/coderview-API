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
    public class EvaluationStateLogic : IEvaluationStateLogic
    {
        private readonly ServiceContext _serviceContext;
        public EvaluationStateLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }
        public List<EvaluationState> GetAllEvaluationState()
        {
            try
            {
                return _serviceContext.Set<EvaluationState>().ToList();
            } catch
            {
                throw new Exception("No se pudieron recuperar los estados de evaluación");
            }
        }

        public int PostEvaluationState(EvaluationState state)
        {
            try
            {
                _serviceContext.EvaluationStates.Add(state);
                _serviceContext.SaveChanges();
                return state.Id;
            }
            catch
            {
                throw new Exception("¡Vaya! No se pudo registrar el estado de evaluación");
            }
        }
    }
}
