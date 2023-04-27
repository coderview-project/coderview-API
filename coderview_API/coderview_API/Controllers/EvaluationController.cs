using coderview_API.Attributes;
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

        [EndpointAuthorize(AllowedUserRols = "Coder")]
        [HttpPost(Name = "SubmitEvaluation")]
        public int SubmitEvaluation (EvaluationItem evaluationItem) 
        {
            return _evaluationService.SubmitEvaluation(evaluationItem);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador")]
        [HttpGet(Name = "GetAllEvaluation")]

        public List<EvaluationItem> GetAllEvaluation()
        {
            return _evaluationService.GetAllEvaluation();
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador, Coder")]
        [HttpGet(Name = "GetEvaluationById")] 

        public List<EvaluationItem> GetEvaluationById(int id) 
        {
            return _evaluationService.GetEvaluationById(id);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador, Coder")]
        [HttpGet(Name ="GetEvaluationByUserId")] 
        public List<EvaluationItem> GetEvaluationByUserId([FromQuery] int id) 
        {
            return _evaluationService.GetEvaluationByUserId(id);
        }

        [EndpointAuthorize(AllowedUserRols = "Administrador, Formador, Coder")]
        [HttpGet(Name = "GetAutoevaluacion")] 
        public List<EvaluationItem> GetAutoevaluacion()
        {
            return _evaluationService.GetAutoevaluacion();
        }


        [EndpointAuthorize(AllowedUserRols = "Administrador")]
        [HttpDelete(Name = "DeactivateEvaluation")]
        public void DeactivateEvaluation([FromQuery] int id)
        {
            _evaluationService.DeactivateEvaluation(id);
        }
    }
}
