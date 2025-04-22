using System.Collections.Generic;
using System.Linq;

namespace UsersApi.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id)!;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void UpdateUser(int id, User updatedUser)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
            }
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}