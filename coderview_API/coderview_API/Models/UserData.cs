﻿namespace coderview_API.Models
{
    public class UserData
    {
        public UserData()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }

}
