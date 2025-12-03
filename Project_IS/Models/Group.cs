using System;
using System.Collections.Generic;
using System.Text;

namespace Project_IS.Models
{
    public class Group    
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } =null!;
        public override string ToString()
        {
            return GroupName;
        }

    }
}
