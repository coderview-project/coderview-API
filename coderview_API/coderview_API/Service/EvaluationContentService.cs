using coderview_API.IService;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class EvaluationContentService : IEvaluationContentService
    {
        private readonly IEvaluationContentLogic _evaluation_ContentLogic;
        public EvaluationContentService(IEvaluationContentLogic evaluation_ContentLogic)
        {
            _evaluation_ContentLogic = evaluation_ContentLogic;
        }

        public List<EvaluationContent> GetAllEvaluationContent()
        {
            return _evaluation_ContentLogic.GetAllEvaluationContent();
        }

        public int AddEvaluationContent(EvaluationContent eContent)
        {
            return _evaluation_ContentLogic.AddEvaluationContent(eContent);
        }

        public void DeleteEvaluationContent(int id)
        {
             _evaluation_ContentLogic.DeleteEvaluationContent(id);
        }
    }
}
