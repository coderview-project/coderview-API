using Data;
using Entities.Enums;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ContentLogic : IContentLogic
    {
        private readonly ServiceContext _serviceContext;

        public ContentLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

         public List<ContentItem> GetAllContent()
        {
            return _serviceContext.Set<ContentItem>()
                .Where(u => u.IsActive==true)
                .ToList();

        }

        public int PostContent(ContentItem contentItem)
        {
            _serviceContext.Content.Add(contentItem);
            _serviceContext.SaveChanges();
            
            return contentItem.Id;
        }

        public void UpdateContent(ContentItem contentItem)
        {
            _serviceContext.Content.Update(contentItem);
            _serviceContext.SaveChanges();
        }

        public void DeactivateContent(int id)
        {
            var contentToDeactivate = _serviceContext.Set<ContentItem>()
                .Where(u => u.Id == id).First();

            contentToDeactivate.IsActive = false;   

            _serviceContext.SaveChanges();

        }      



    }
}
