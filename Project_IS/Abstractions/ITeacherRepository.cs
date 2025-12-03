using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();        
        Teacher GetById(int id);                 
        Teacher GetByUserId(int userId);         
        void Add(Teacher teacher);              
        void Update(Teacher teacher);      
        void Delete(int id);

    }
}
