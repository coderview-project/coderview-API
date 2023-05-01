using coderview_API.IService;
using coderview_API.Models;
using Data;
using Entities;
using Entities.Enums;
using Logic.ILogic;
using Logic.Logic;

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

        public int AddContente(ContentItem contentItem)
        {
            _contentLogic.AddContent(contentItem);
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

        // Creamos una nueva clase y Validamos elementos de la clase ContentItem
        public int AddContent(ContentItem contentItem)
        {
            //var content = contentItem.Tobcontent);

            if (!ValidateContent(contentItem))
            {
                throw new InvalidDataException();
            }
            _contentLogic.AddContent(contentItem);
            if (!ValidateInsertedContent(contentItem))
            {
                throw new InvalidOperationException();
            }

            return contentItem.Id;
        }
        // Creamos una nueva clase y Validamos elementos de la clase ContentItem

        public static bool ValidateContent(ContentItem contentItem)
            {

                if (contentItem == null)
                {
                    return false;
                }
                if (contentItem.Title == null|| contentItem.Title == "")
                {
                    return false;
                }
                if (contentItem.SkillId == null /*|| contentItem.SkillId == ""*/)
                {
                    return false;
                }
                             
                return true;
            }
            public static bool ValidateInsertedContent(ContentItem contentItem)
            {
                if (!ValidateContent(contentItem))
                {
                    return false;
                }
                if (contentItem.Id < 1)
                {
                    return false;
                }
                return true;
            }

    }
}
           
         
    

