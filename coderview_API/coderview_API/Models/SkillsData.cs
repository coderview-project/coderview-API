using Entities;

namespace coderview_API.Models
{
    public class SkillsData
    {
       public SkillsData()
        {
             IsActive = true;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Criteria { get; set; }
        public string Actions { get; set; }
        public bool IsActive { get; set; }

    }
}

