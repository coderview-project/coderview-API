using coderview_API.Attributes;
using coderview_API.IService;
using coderview_API.Service;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
     public class EvaluationDataController : ControllerBase
     {

        private readonly IEvaluationDataService _evaluationDataService;
        public EvaluationDataController(IEvaluationDataService evaluationDataService)
        {
            _evaluationDataService = evaluationDataService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "SubmitEvaluation")]
        public int SubmitEvaluation([FromBody] EvaluationData data)
        {
            return _evaluationDataService.SubmitEvaluation(data);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetEvaluationData")] 
        public List<EvaluationData> GetEvaluationData()
        {
            return _evaluationDataService.GetEvaluationData();
        }
    }
}
