
using coderview_API.Attributes;
using coderview_API.IService;
using coderview_API.Models;
using coderview_API.Service;
using Data;
using Entities;
using Entities.Enums;
using Microsoft.AspNetCore.Authorization;
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

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpGet(Name = "GetAllContent")]
         public List<ContentItem> GetAllContent()
        {
            return _contentService.GetAllContent();
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPatch(Name = "ModifyContent")]
        public void UpdateContent([FromBody] ContentItem contentItem)
        {
                _contentService.UpdateContent(contentItem);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpDelete(Name ="DeactivateContent")]
        public void DeactivateContent([FromQuery] int id)
        {
            _contentService.DeactivateContent(id);
        }

        [EndpointAuthorize(AllowsAnonymous = true)]
        [HttpPost(Name = "PostContent")]
        public int PostContent([FromForm] ContentItem contentItem)
        {            
           return _contentService.PostContent(contentItem);
            
        }
    }
}
    
    