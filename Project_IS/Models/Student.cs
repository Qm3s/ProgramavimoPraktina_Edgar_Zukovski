using System;
using System.Collections.Generic;
using System.Text;

namespace Project_IS.Models
{
    public class Student : User
    {
        public int StudentId { get; set; }    
        public int? GroupId { get; set; }     
      


        public override string ShowInfo()
        {
            return $"Student: {FirstName} {LastName}";
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }

}
