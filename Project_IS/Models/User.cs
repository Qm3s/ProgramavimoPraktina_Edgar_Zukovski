using System;
using System.Collections.Generic;
using System.Text;
namespace Project_IS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        public virtual string ShowInfo()
        {
            return $"{FirstName} {LastName} ({Role})";
        }
    }

}