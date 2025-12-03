using System;
using System.Collections.Generic;
using System.Text;

namespace Project_IS.Models
{
    public class Teacher : User
    {
        public int TeacherId { get; set; }   

        //public int UserId { get; set; }

        public override string ShowInfo()
        {
            return $"Teacher: {FirstName} {LastName}";
        }
    }

}
