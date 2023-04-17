using coderview_API.IService;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace coderview_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Evaluation_ContentController : ControllerBase
    {
        private readonly IEvaluation_ContentService _evaluation_contentService; 
        public Evaluation_ContentController(IEvaluation_ContentService evaluation_ContentService)
        {
            _evaluation_contentService= evaluation_ContentService;
        }

        [HttpGet(Name = "GetAllEvaluation_Content")]

        public List<Evaluation_Content> GetAllEvaluation_Content()
        {
           return _evaluation_contentService.GetAllEvaluation_Content();
        }

        [HttpPost(Name = "PostEvaluation_Content")]

        public int PostEvaluation_Content(Evaluation_Content eContent)
        {
            return _evaluation_contentService.PostEvaluation_Content(eContent);
        }

        public void DeleteEvaluation_Content([FromQuery] int id)
        {
            _evaluation_contentService.DeleteEvaluation_Content(id);
        }

    }
}
