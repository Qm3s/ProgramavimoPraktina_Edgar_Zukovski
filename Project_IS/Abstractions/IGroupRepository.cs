using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    internal interface IGroupRepository
    {
        IEnumerable<Group> GetAll();       
        Group GetById(int id);             
        Group GetByName(string name);      
        void Add(Group group);           
        void Update(Group group);          
        void Delete(int id);              

    }
}
