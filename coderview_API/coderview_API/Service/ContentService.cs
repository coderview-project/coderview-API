using coderview_API.IService;
using Data;
using Entities;
using Entities.Enums;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class ContentService : IContentService
    {
        private readonly IContentLogic  _contentLogic;

        public ContentService(IContentLogic contentLogic)
        {
            _contentLogic= contentLogic;

        }
        public List<ContentItem> GetAllContent()
        {
            return _contentLogic.GetAllContent();
        }

        public int PostContent(ContentItem contentItem)
        {
           return _contentLogic.PostContent(contentItem);
            
        }

        public void UpdateContent(ContentItem contentItem)
        {
            _contentLogic.UpdateContent(contentItem);
           
        }

        public void DeactivateContent(int id)
        {
            _contentLogic.DeactivateContent(id);
        }
        

    }
}
