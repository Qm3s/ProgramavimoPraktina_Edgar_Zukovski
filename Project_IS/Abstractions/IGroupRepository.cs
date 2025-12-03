using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    internal interface IGroupRepository
    {
        IEnumerable<Group> GetAll();       // Все группы
        Group GetById(int id);             // Группа по Id
        Group GetByName(string name);      // По названию группы
        void Add(Group group);             // Добавить новую группу
        void Update(Group group);          // Обновить группу
        void Delete(int id);               // Удалить группу

    }
}
