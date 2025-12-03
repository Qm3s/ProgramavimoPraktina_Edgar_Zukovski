using Project_IS.Abstractions;
using Project_IS.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project_IS.Services
{
    public class TeacherService
    {
        private readonly ISubjectRepository _subjectRepo;
        private readonly IGroupRepository _groupRepo;
        private readonly IStudentRepository _studentRepo;
        private readonly IGradeRepository _gradeRepo;
        private readonly IGroupSubjectRepository _groupSubjectRepo;
        private readonly ITeacherSubjectRepository _teacherSubjectRepo;

        public TeacherService()
        {
            string conn = DatabaseConfig.ConnectionString;

            _subjectRepo = new SubjectRepository(conn);
            _groupRepo = new GroupRepository(conn);
            _studentRepo = new StudentRepository(conn);
            _gradeRepo = new GradeRepository(conn);
            _groupSubjectRepo = new GroupSubjectRepository(conn);
            _teacherSubjectRepo = new TeacherSubjectRepository(conn);
        }

        // 1. Предметы, которые ведет учитель
        public IEnumerable<Subject> GetSubjectsForTeacher(int teacherId)
        {
            var subjectIds = _teacherSubjectRepo.GetSubjectsByTeacher(teacherId);

            return subjectIds
                .Select(id => _subjectRepo.GetById(id))
                .Where(s => s != null)
                .ToList();
        }

        // 2. Группы, которые изучают предмет
        public IEnumerable<Group> GetGroupsForSubject(int subjectId)
        {
            var groupIds = _groupSubjectRepo.GetGroupsBySubject(subjectId);

            return groupIds
                .Select(id => _groupRepo.GetById(id))
                .Where(g => g != null)
                .ToList();
        }

        // 3. Список студентов в группе
        public IEnumerable<Student> GetStudentsInGroup(int groupId)
        {
            return _studentRepo.GetAll()
                .Where(s => s.GroupId == groupId)
                .ToList();
        }

        // 4. Добавить оценку
        public void AddGrade(int studentId, int subjectId, int value)
        {
            Grade grade = new Grade
            {
                StudentId = studentId,
                SubjectId = subjectId,
                Value = value
            };

            _gradeRepo.Add(grade);
        }

        // 5. Оценки студента по предмету
        public IEnumerable<Grade> GetGrades(int studentId, int subjectId)
        {
            return _gradeRepo.GetByStudentId(studentId)
                .Where(g => g.SubjectId == subjectId)
                .ToList();
        }
    }
}
