using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationContentService
    {
        int PostEvaluationContent(EvaluationContent eContent);
        List<EvaluationContent> GetAllEvaluationContent();
        void DeleteEvaluationContent(int id);
    }
}
