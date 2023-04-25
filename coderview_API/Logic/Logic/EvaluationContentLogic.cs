using Data;
using Entities;
using Logic.ILogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class EvaluationContentLogic : IEvaluationContentLogic
    {
        private readonly ServiceContext _serviceContext; 
        public EvaluationContentLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<EvaluationContent> GetAllEvaluationContent()
        {
            try
            {
                return _serviceContext.Set<EvaluationContent>().ToList();
            } catch
            {
                throw new Exception("Algo salió mal. No se pudo recuperar las entradas");
            }
        }

        public int PostEvaluationContent(EvaluationContent econtent)
        {
            try
            {
                _serviceContext.EvaluationContents.Add(econtent);
                _serviceContext.SaveChanges();
                return econtent.Id;
            } catch
            {
                throw new Exception("No se pudo crear la entrada");
            }
        }
        public void DeleteEvaluationContent(int id)
        {
            try
            {
                _serviceContext.EvaluationContents.Remove(_serviceContext.Set<EvaluationContent>().Where(ec => ec.Id == id).FirstOrDefault());
                _serviceContext.SaveChanges();
                
            } catch
            {
                throw new Exception("No se pudo borrar la entrada");
            }
        }
    }
}
