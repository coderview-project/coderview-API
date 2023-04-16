using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EvaluationStateController : ControllerBase
    {
        private readonly IEvaluationStateService _evaluationStateService;
        public EvaluationStateController(IEvaluationStateService evaluationStateService)
        {
            _evaluationStateService = evaluationStateService;
        }

        [HttpGet(Name = "GetAllEvaluationState")]

        public List<EvaluationState> GetAllEvaluationState()
        {
            return _evaluationStateService.GetAllEvaluationState();
        }

        [HttpPost(Name = "PostEvaluationState")]

        public int PostEvaluationState(EvaluationState state)
        {
            return _evaluationStateService.PostEvaluationState(state);
        }

    }
        
}

