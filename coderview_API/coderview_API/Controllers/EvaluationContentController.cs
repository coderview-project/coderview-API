using coderview_API.Attributes;
using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EvaluationContentController : ControllerBase
    {
        private readonly IEvaluationContentService _evaluation_contentService; 
        public EvaluationContentController(IEvaluationContentService evaluation_ContentService)
        {
            _evaluation_contentService= evaluation_ContentService;
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllEvaluation_Content")]

        public List<EvaluationContent> GetAllEvaluation_Content()
        {
           return _evaluation_contentService.GetAllEvaluationContent();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "PostEvaluation_Content")]

        public int AddEvaluation_Content(EvaluationContent eContent)
        {
            return _evaluation_contentService.AddEvaluationContent(eContent);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name = "DeleteEvaluation_Content")]

        public void DeleteEvaluation_Content([FromQuery] int id)
        {
            _evaluation_contentService.DeleteEvaluationContent(id);
        }

    }
}
