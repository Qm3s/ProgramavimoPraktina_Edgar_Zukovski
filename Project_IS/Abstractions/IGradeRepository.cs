using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    internal interface IGradeRepository
{
    IEnumerable<Grade> GetAll();
    Grade? GetById(int id);
    IEnumerable<Grade> GetByStudentId(int studentId);
    IEnumerable<Grade> GetBySubjectId(int subjectId);
    void Add(Grade grade);
    void Update(Grade grade);
    void Delete(int id);
}

}

