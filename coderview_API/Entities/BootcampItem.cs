
namespace Entities
{
    public class BootcampItem
    {
        public BootcampItem() 
        {
            IsActive = true;
        }
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
