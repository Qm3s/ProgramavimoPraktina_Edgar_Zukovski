using System.Collections.Generic;
using Project_IS.Abstractions;
using Project_IS.Models;

namespace Project_IS.Services
{
    public class AdminService
    {
        private readonly IUserRepository _userRepo;
        private readonly IGroupRepository _groupRepo;
        private readonly ISubjectRepository _subjectRepo;
        private readonly ITeacherRepository _teacherRepo;
        private readonly IStudentRepository _studentRepo;

        public AdminService()
        {
            string conn = DatabaseConfig.ConnectionString;

            _userRepo = new UserRepository(conn);
            _groupRepo = new GroupRepository(conn);
            _subjectRepo = new SubjectRepository(conn);
            _teacherRepo = new TeacherRepository(conn);
            _studentRepo = new StudentRepository(conn);
        }

        //USERS
        public IEnumerable<User> GetUsers() => _userRepo.GetAll();
        public void AddUser(User u) => _userRepo.Add(u);
        public void DeleteUser(int userId) => _userRepo.Delete(userId);
        public void UpdateUser(User u) => _userRepo.Update(u);

        //GROUPS
        public IEnumerable<Group> GetGroups() => _groupRepo.GetAll();
        public void AddGroup(Group g) => _groupRepo.Add(g);
        public void UpdateGroup(Group g) => _groupRepo.Update(g);
        public void DeleteGroup(int id) => _groupRepo.Delete(id);

        //SUBJECTS
        public IEnumerable<Subject> GetSubjects() => _subjectRepo.GetAll();
        public void AddSubject(Subject s) => _subjectRepo.Add(s);
        public void UpdateSubject(Subject s) => _subjectRepo.Update(s);
        public void DeleteSubject(int id) => _subjectRepo.Delete(id);
        public Subject GetSubjectById(int id) => _subjectRepo.GetById(id);

        //STUDENTS GROUP ASSIGNMENT

        
        public Student GetStudentByUserId(int userId) => _studentRepo.GetByUserId(userId);

        
        public IEnumerable<Student> GetStudentsByGroup(int groupId) =>
            _studentRepo.GetAll().Where(s => s.GroupId == groupId);

      
        public void AssignStudentToGroup(int studentId, int groupId)
        {
            var st = _studentRepo.GetById(studentId);
            if (st == null) return;

            st.GroupId = groupId;
            _studentRepo.Update(st);
        }
    }
}
