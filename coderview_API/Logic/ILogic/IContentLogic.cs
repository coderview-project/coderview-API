using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IContentLogic
    {
        int AddContent(ContentItem contentItem);
        void DeactivateContent(int id);
        List<ContentItem> GetAllContent();
        void UpdateContent(ContentItem contentItem);
    }
}
