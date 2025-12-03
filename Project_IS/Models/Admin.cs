using System;
using System.Collections.Generic;
using System.Text;

namespace Project_IS.Models
{
    public class Admin : User
    {
        public override string ShowInfo()
        {
            return $"Administrator: {FirstName} {LastName}";
        }
    }

}
