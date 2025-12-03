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

        public TeacherService()
        {
            string conn = DatabaseConfig.ConnectionString;

            _subjectRepo = new SubjectRepository(conn);
            _groupRepo = new GroupRepository(conn);
            _studentRepo = new StudentRepository(conn);
            _gradeRepo = new GradeRepository(conn);
        }

       
        public IEnumerable<Group> GetAllGroups()
        {
            return _groupRepo.GetAll().ToList();
        }

        
        public IEnumerable<Student> GetStudentsByGroup(int groupId)
        {
            return _studentRepo.GetAll()
                .Where(s => s.GroupId == groupId)
                .ToList();
        }

        
        public IEnumerable<Subject> GetAllSubjects()
        {
            return _subjectRepo.GetAll().ToList();
        }

       
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

        
        public IEnumerable<Grade> GetGrades(int studentId, int subjectId)
        {
            return _gradeRepo.GetByStudentId(studentId)
                .Where(g => g.SubjectId == subjectId)
                .ToList();
        }
    }
}
