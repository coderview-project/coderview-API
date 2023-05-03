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
        public void UpdateContent(ContentItem contentItem)
        {
            _contentLogic.UpdateContent(contentItem);
         
        }
        public void DeactivateContent(int id)
        {
            _contentLogic.DeactivateContent(id);
        }       
        public int AddContent(ContentItem contentItem)
        {   
            if (!ValidateContent(contentItem))
            {
                return _contentLogic.AddContent(contentItem);
               
            }
            else                        
            {
                throw new InvalidOperationException();
            }            

        }        

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
                if (contentItem.SkillId ==  null)
                {
                    return false;
                }                             
                return true;
        }
        
    }
}
           
         
    

