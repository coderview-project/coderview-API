using coderview_API.IService;
using Entities;
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

        [HttpGet(Name = "GetAllEvaluation_Content")]

        public List<EvaluationContent> GetAllEvaluation_Content()
        {
           return _evaluation_contentService.GetAllEvaluationContent();
        }

        [HttpPost(Name = "PostEvaluation_Content")]

        public int PostEvaluation_Content(EvaluationContent eContent)
        {
            return _evaluation_contentService.PostEvaluationContent(eContent);
        }

        [HttpDelete(Name = "DeleteEvaluation_Content")]

        public void DeleteEvaluation_Content([FromQuery] int id)
        {
            _evaluation_contentService.DeleteEvaluationContent(id);
        }

    }
}
