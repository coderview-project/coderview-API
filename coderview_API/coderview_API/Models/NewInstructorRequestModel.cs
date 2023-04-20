using Entities;

namespace coderview_API.Models
{
    public class NewInstructorRequestModel
    {
        public int UserRolId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserItem ToUserItem()
        {
            var userItem = new UserItem();

            userItem.UserRolId = 2;
            userItem.UserName = UserName;
            userItem.LastName = LastName;
            userItem.Email = Email;
            userItem.InsertDate = DateTime.Now;
            userItem.UpdateDate = DateTime.Now;
            userItem.IsActive = true;

            return userItem;
        }
    }
}

