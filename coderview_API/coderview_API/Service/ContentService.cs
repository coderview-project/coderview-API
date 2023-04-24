using coderview_API.IService;
using Data;
using Entities.Enums;
using Logic.ILogic;

namespace coderview_API.Service
{
    public class ContentService : IContentService
    {
        private readonly IContentLogic  _contentLogic;

        private readonly ServiceContext _serviceContext;

        public ContentService(ServiceContext serviceContext, IContentLogic contentLogic)
        {
            _serviceContext = serviceContext;
            _contentLogic= contentLogic;

        }
        public List<ContentItem> GetAllContent()
        {
            return _contentLogic.GetAllContent();
        }

        public int PostContent(ContentItem contentItem)
        {
            _contentLogic.PostContent(contentItem);
            return contentItem.Id;
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
