using Project_IS.Abstractions;
using Project_IS.Models;


namespace Project_IS.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepo;
        private readonly ITeacherRepository _teacherRepo;
        private readonly IStudentRepository _studentRepo;

        public AuthService()
        {
            string conn = DatabaseConfig.ConnectionString;

            _userRepo = new UserRepository(conn);
            _teacherRepo = new TeacherRepository(conn);
            _studentRepo = new StudentRepository(conn);
        }

        public User? Login(string username, string password)
        {
            var user = _userRepo.GetByUsername(username);

            if (user == null)
                return null;

            if (user.Password != password)
                return null;

            return CreateUserByRole(user);
        }

        private User CreateUserByRole(User baseUser)
        {
            switch (baseUser.Role.ToLower())
            {
                case "admin":
                    return new Admin
                    {
                        UserId = baseUser.UserId,
                        FirstName = baseUser.FirstName,
                        LastName = baseUser.LastName,
                        Username = baseUser.Username,
                        Password = baseUser.Password,
                        Role = baseUser.Role
                    };

                case "teacher":
                    var teacher = _teacherRepo.GetByUserId(baseUser.UserId);

                    return new Teacher
                    {
                        UserId = baseUser.UserId,
                        TeacherId = teacher.TeacherId,       
                        FirstName = baseUser.FirstName,
                        LastName = baseUser.LastName,
                        Username = baseUser.Username,
                        Password = baseUser.Password,
                        Role = baseUser.Role
                    };

                case "student":
                    var student = _studentRepo.GetByUserId(baseUser.UserId);

                    return new Student
                    {
                        UserId = baseUser.UserId,
                        StudentId = student.StudentId,      
                        GroupId = student.GroupId,
                        FirstName = baseUser.FirstName,
                        LastName = baseUser.LastName,
                        Username = baseUser.Username,
                        Password = baseUser.Password,
                        Role = baseUser.Role
                    };

                default:
                    return baseUser;
            }
        }
    }
}
