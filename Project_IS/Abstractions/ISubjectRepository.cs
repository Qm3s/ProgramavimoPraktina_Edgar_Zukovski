using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();      
        Subject GetById(int id);          
        Subject GetByName(string name);       
        void Add(Subject subject);            
        void Update(Subject subject);  
        void Delete(int id);

    }
}
