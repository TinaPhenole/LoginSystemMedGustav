namespace Enkelt_login_system
{
    public class User
        {
            public string Name { get; set; }
            public string Password { get; set; }

            public User(string username, string password)
            {
                Name = username;
                Password = password;
            }
        }      
}
