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
    public class Evaluation_ContentLogic : IEvaluation_ContentLogic
    {
        private readonly ServiceContext _serviceContext; 
        public Evaluation_ContentLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public List<Evaluation_Content> GetAllEvaluation_Content()
        {
            try
            {
                return _serviceContext.Set<Evaluation_Content>().ToList();
            } catch
            {
                throw new Exception("Algo salió mal. No se pudo recuperar las entradas");
            }
        }

        public int PostEvaluation_Content(Evaluation_Content econtent)
        {
            try
            {
                _serviceContext.Evaluation_Contents.Add(econtent);
                _serviceContext.SaveChanges();
                return econtent.Id;
            } catch
            {
                throw new Exception("No se pudo crear la entrada");
            }
        }
        public void DeleteEvaluation_Content(int id)
        {
            try
            {
                _serviceContext.Evaluation_Contents.Remove(_serviceContext.Set<Evaluation_Content>().Where(ec => ec.Id == id).FirstOrDefault());
                _serviceContext.SaveChanges();
                
            } catch
            {
                throw new Exception("No se pudo borrar la entrada");
            }
        }
    }
}
