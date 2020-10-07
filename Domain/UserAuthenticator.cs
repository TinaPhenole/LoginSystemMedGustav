using System.Collections.Generic;

namespace Enkelt_login_system
{
    public class UserAuthentication
    {
        private List<User> users = new List<User>();
        public void AddUser(string username, string password)
        {
            User newUser = new User(username, password);
            users.Add(newUser);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public bool TryValidateUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Name == username && user.Password == password) return true;
            }
            return false;

        }
    }
}