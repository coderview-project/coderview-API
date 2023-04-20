
using coderview_API.IService;
using coderview_API.Models;
using coderview_API.Service;
using Data;
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

        [HttpGet(Name ="GetAllContent")]

         List<ContentItem> GetAllContent()
        {
            return _contentService.GetAllContent();

        }
        [HttpPatch(Name = "ModifyContent")]

        public void Pactch( [FromBody] PatchContentRequestModel patchContentRequestModel)
        {
            try
            {
                var contentItem = new ContentItem();

                contentItem.Id = 0;
                contentItem.Title = patchContentRequestModel.ContentData.Title;
                contentItem.SkillId = patchContentRequestModel.ContentData.SkillId;
                _contentService.UpdateContent(contentItem);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpDelete(Name ="DeactivateContent")]

        public void DeactivateContent([FromQuery] int id)
        {
            _contentService.DeactivateContent(id);
        }

        [HttpPost(Name = "PostContent")]

        public int PostContent([FromForm] ContentItem contentItem)
        {
            using (var stream = new MemoryStream())
            {
                contentItem.Content.Add(contentItem);
                contentItem.content = stream.ToArray();

                return _contentService.PostContent(contentItem);
            }
            





        }
    }
}
    
    