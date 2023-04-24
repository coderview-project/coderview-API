using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SkillsItem
    {
        public SkillsItem()
        { 
            IsActive = true;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Criteria{ get; set; }
        public string  Actions { get; set; }
        public bool IsActive { get; set; }

    }

    
     
  
}
