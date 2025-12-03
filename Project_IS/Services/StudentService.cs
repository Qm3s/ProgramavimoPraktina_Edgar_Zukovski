using System;
using System.Collections.Generic;
using System.Text;
using Project_IS.Abstractions;
using Project_IS.Models;

namespace Project_IS.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepo;
        private readonly IGradeRepository _gradeRepo;
        private readonly ISubjectRepository _subjectRepo;

        public StudentService()
        {
            _studentRepo = new StudentRepository(DatabaseConfig.ConnectionString);
            _gradeRepo = new GradeRepository(DatabaseConfig.ConnectionString);
            _subjectRepo = new SubjectRepository(DatabaseConfig.ConnectionString);
        }

        
        public Student GetStudentByUserId(int userId)
        {
            return _studentRepo.GetByUserId(userId);
        }

        
        public IEnumerable<(Subject Subject, List<int> Grades)> GetSubjectsAndGrades(int studentId) 
        {
            var grades = _gradeRepo.GetByStudentId(studentId);

            var grouped = grades
                .GroupBy(g => g.SubjectId)
                .Select(group =>
                {
                    var subject = _subjectRepo.GetById(group.Key);
                    var gradesList = group.Select(g => g.Value).ToList();

                    return (subject, gradesList);
                });

            return grouped;
        }
        public List<(string SubjectName, string GradesText)> GetGradesTable(int studentId)
        {
            var result = GetSubjectsAndGrades(studentId);

            List<(string SubjectName, string GradesText)> table = new();

            foreach (var item in result)
            {
                string gradesText = string.Join("   ", item.Grades);
                table.Add((item.Subject.SubjectName, gradesText));
            }

            return table;
        }

    }
}
