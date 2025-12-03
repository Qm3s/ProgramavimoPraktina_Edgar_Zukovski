using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Models;
namespace Project_IS.Abstractions
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();           // Все преподаватели
        Teacher GetById(int id);                 // Преподаватель по Id
        Teacher GetByUserId(int userId);         // Получить преподавателя по Id пользователя (UserId)
        void Add(Teacher teacher);               // Добавить нового преподавателя
        void Update(Teacher teacher);            // Обновить преподавателя
        void Delete(int id);

    }
}
