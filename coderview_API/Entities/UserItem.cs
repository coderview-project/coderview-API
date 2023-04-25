
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserItem
    {
        public UserItem()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        //public int IdPhotoFile { get; set; }
        public int UserRolId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string EncryptedPassword { get; set; }
        public string EncryptedToken { get; set; }
        public DateTime TokenExpireDate { get; set; }

    }
}