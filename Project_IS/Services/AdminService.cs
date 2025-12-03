using System.Collections.Generic;
using Project_IS.Abstractions;
using Project_IS.Models;

namespace Project_IS.Services
{
    public class AdminService
    {
        private readonly IUserRepository _userRepo;
        private readonly IGroupRepository _groupRepo;

        public AdminService()
        {
            string conn = DatabaseConfig.ConnectionString;
            _userRepo = new UserRepository(conn);
            _groupRepo = new GroupRepository(conn);
        }

        // ---------- USERS ----------
        public IEnumerable<User> GetUsers() => _userRepo.GetAll();

        public void AddUser(User u) => _userRepo.Add(u);

        public void DeleteUser(int userId) => _userRepo.Delete(userId);

        public void UpdateUser(User u) => _userRepo.Update(u);

        public IEnumerable<Group> GetGroups() => _groupRepo.GetAll();

        public void AddGroup(Group g) => _groupRepo.Add(g);

        public void UpdateGroup(Group g) => _groupRepo.Update(g);

        public void DeleteGroup(int id) => _groupRepo.Delete(id);
    }
}
