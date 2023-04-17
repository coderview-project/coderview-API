using Entities;

namespace coderview_API.IService
{
    public interface IEvaluation_ContentService
    {
        int PostEvaluation_Content(Evaluation_Content eContent);
        List<Evaluation_Content> GetAllEvaluation_Content();
        void DeleteEvaluation_Content(int id);
    }
}
