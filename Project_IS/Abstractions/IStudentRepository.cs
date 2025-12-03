using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();        
        Student GetById(int id);
        Student GetByUserId(int userId);
        void Add(Student student);                
        void Update(Student student);
        void Delete(int id);
    }
}
