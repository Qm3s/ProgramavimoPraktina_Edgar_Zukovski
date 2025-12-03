using System;
using System.Collections.Generic;
using System.Text;

namespace Project_IS.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; } = null!;
        public override string ToString()
        {
            return SubjectName;
        }

    }
}
