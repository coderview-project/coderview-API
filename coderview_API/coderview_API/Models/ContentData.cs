namespace coderview_API.Models
{
    public class ContentData
    {
        public ContentData()
        {
            IsActive = true;

        }        
        public int Id { get; set; }
        public string Title { get; set; }
        public int SkillId { get; set; }

        public bool IsActive { get; set; }

    }
}
