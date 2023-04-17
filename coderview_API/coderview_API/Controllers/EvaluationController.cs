using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EvaluationController : ControllerBase
    {
        private readonly IEvaluationService _evaluationService; 
        public EvaluationController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        [HttpPost(Name = "SubmitEvaluation")]

        public int SubmitEvaluation (EvaluationItem evaluationItem) 
        {
            return _evaluationService.SubmitEvaluation(evaluationItem);
        }

        [HttpGet(Name = "GetAllEvaluation")]

        public List<EvaluationItem> GetAllEvaluation()
        {
            return _evaluationService.GetAllEvaluation();
        }

        [HttpGet(Name = "GetEvaluationById")] 

        public int GetEvaluationById(int id) 
        {
            return _evaluationService.GetEvaluationById(id);
        }

        [HttpDelete(Name = "DeactivateEvaluation")]
        public void DeactivateEvaluation([FromQuery] int id)
        {
            _evaluationService.DeactivateEvaluation(id);
        }
    }
}
