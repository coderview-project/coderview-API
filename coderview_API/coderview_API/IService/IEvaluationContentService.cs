using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationContentService
    {
        int AddEvaluationContent(EvaluationContent eContent);
        List<EvaluationContent> GetAllEvaluationContent();
        void DeleteEvaluationContent(int id);
    }
}
