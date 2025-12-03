using System;
using System.Collections.Generic;
using System.Text;

namespace Project_IS.Models
{
    public class Grade  
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Value  { get; set; }


    }
}
