
using coderview_API.IService;
using coderview_API.Models;
using coderview_API.Service;
using Data;
using Entities;
using Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace coderview_API.Controllers
{

    [ApiController]
    [Route ("[controller]/[action]")]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;       

        public  ContentController(IContentService contentService)
        {
            _contentService = contentService;          
        }

        [HttpGet(Name = "GetAllContent")]
         public List<ContentItem> GetAllContent()
        {
            return _contentService.GetAllContent();
        }


        [HttpPatch(Name = "ModifyContent")]
        public void UpdateContent([FromBody] ContentItem contentItem)
        {
                _contentService.UpdateContent(contentItem);
        }

        [HttpDelete(Name ="DeactivateContent")]
        public void DeactivateContent([FromQuery] int id)
        {
            _contentService.DeactivateContent(id);
        }

        [HttpPost(Name = "PostContent")]
        public int AddContent([FromForm] ContentItem contentItem)
        {            
           return _contentService.AddContent(contentItem);
            
        }
    }
}
    
    