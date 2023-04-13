using Entities;

namespace coderview_API.IService
{
    public interface IEvaluationTypeService
    {
        List<EvaluationType> GetAllEvaluationType();
        int PostEvaluationType(EvaluationType type);
    }
}
