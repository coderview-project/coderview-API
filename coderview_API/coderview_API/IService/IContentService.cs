using Entities;
using Entities.Enums;

namespace coderview_API.IService
{
    public interface IContentService
    {
        void DeactivateContent(int id);
        List<ContentItem> GetAllContent();
        int AddContent(ContentItem contentItem);
        void UpdateContent(ContentItem contentItem);
    }
}
