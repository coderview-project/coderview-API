using Data;
using Entities;
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
        public void DeactivateContent(int id)
        {
            try
            {
                var contentToDeactivate = _serviceContext.Set<ContentItem>().Where(c => c.Id == id).First();
                contentToDeactivate.IsActive = false;
                _serviceContext.SaveChanges();
            }
            catch
            {
                throw new Exception("Algo salió mal. Su contenido no se ha desactivado");
            }

        }

        public List<ContentItem> GetAllContent()
        {
            return _serviceContext.Set<ContentItem>().Where(c => c.IsActive == true).ToList();
        }

        public int PostContent(ContentItem contentItem)
        {
            try
            {
                _serviceContext.Contents.Add(contentItem);
                _serviceContext.SaveChanges();
                return contentItem.Id;
            }
            catch
            {
                throw new Exception("¡Vaya! El contenido no ha sido registrado correctamente.");
            }
        }

        public void UpdateContent(ContentItem contentItem)
        {
            _serviceContext.Contents.Update(contentItem);
            _serviceContext.SaveChanges();
        }
    }
}
