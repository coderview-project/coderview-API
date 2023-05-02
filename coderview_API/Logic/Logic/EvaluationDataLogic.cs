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
    public class EvaluationDataLogic : IEvaluationDataLogic
    {
        private readonly ServiceContext _serviceContext;
        public EvaluationDataLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public int SubmitEvaluation(EvaluationData data)
        {
            _serviceContext.EvaluationDatas.Add(data);
            _serviceContext.SaveChanges();
            return data.Id;
        }

        public List<EvaluationData> GetEvaluationData()
        {
            return _serviceContext.Set<EvaluationData>().ToList();
        }

        public List<EvaluationData> GetSelectedEvaluationData(int id)
        {
            var selectedEvaluation = _serviceContext.Set<EvaluationData>().Where(e => e.EvaluatorId == id).ToList();
            return selectedEvaluation;

        }
    }
}
