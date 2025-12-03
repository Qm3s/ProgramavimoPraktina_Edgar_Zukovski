using System;
using System.Collections.Generic;
using System.Text;


using Project_IS.Models; 

namespace Project_IS.Abstractions
    {
        public interface IUserRepository
        {
            IEnumerable<User> GetAll();
            User GetById(int id);
            User GetByUsername(string username); 
            void Add(User user);                
            void Update(User user);
            void Delete(int id);
    }
    }

