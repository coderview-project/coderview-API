using coderview_API.IService;
using Entities;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class Evaluation_ContentService : IEvaluation_ContentService
    {
        private readonly IEvaluation_ContentLogic _evaluation_ContentLogic;
        public Evaluation_ContentService(IEvaluation_ContentLogic evaluation_ContentLogic)
        {
            _evaluation_ContentLogic = evaluation_ContentLogic;
        }

        public List<Evaluation_Content> GetAllEvaluation_Content()
        {
            return _evaluation_ContentLogic.GetAllEvaluation_Content();
        }

        public int PostEvaluation_Content(Evaluation_Content eContent)
        {
            return _evaluation_ContentLogic.PostEvaluation_Content(eContent);
        }

        public void DeleteEvaluation_Content(int id)
        {
             _evaluation_ContentLogic.DeleteEvaluation_Content(id);
        }
    }
}
