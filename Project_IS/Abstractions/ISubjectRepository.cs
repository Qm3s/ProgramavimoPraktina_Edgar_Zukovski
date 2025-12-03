using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();        // Все предметы
        Subject GetById(int id);              // Предмет по Id
        Subject GetByName(string name);       // По названию предмета
        void Add(Subject subject);            // Добавить новый предмет
        void Update(Subject subject);         // Обновить предмет
        void Delete(int id);

    }
}
