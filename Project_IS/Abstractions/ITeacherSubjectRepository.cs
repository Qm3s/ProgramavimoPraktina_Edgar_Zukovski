using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;

namespace Project_IS.Abstractions
{
    public interface ITeacherSubjectRepository
    {
        IEnumerable<int> GetSubjectsByTeacher(int teacherId);
        IEnumerable<int> GetTeachersBySubject(int subjectId);
        void Add(int teacherId, int subjectId);
        void Delete(int teacherId, int subjectId);
    }

}
