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
    public class EvaluationTypeLogic : IEvaluationTypeLogic
    {
        private readonly ServiceContext _serviceContext; 
        public EvaluationTypeLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<EvaluationType> GetAllEvaluationType()
        {
            try
            {
               return _serviceContext.Set<EvaluationType>().ToList();
            } catch
            {
                throw new Exception("Algo salió mal. No se pudo recuperar los tipos de evaluación");
            }
        }

        public int PostEvaluationType(EvaluationType type)
        {
            try
            {
                _serviceContext.EvaluationTypes.Add(type);
                _serviceContext.SaveChanges();
                return type.Id;
            }
            catch
            {
                throw new Exception("¡Vaya! No se pudo registrar el tipo de evaluación");
            }
        }
    }
}
