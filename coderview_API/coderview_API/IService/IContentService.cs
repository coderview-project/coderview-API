using Entities.Enums;

namespace coderview_API.IService
{
    public interface IContentService
    {
        void DeactivateContent(int id);
        List<ContentItem> GetAllContent();
        int PostContent(ContentItem contentItem);
        void UpdateContent(ContentItem contentItem);

        public interface IContentService
        {
            int PostContent(ContentItem contentItem);
            void UpdateContent(int id);
            void DeactivateContent(int id);
            List<ContentItem> GetAllContent();    
        }
    }
}
