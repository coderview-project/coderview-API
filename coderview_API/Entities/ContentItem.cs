using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContentItem
    {
        public ContentItem()
        {
            IsActive = true; 
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int SkillId { get; set; }

        public bool IsActive { get; set; }
    }
}
