namespace Enkelt_login_system
{
    public class User
        {
            public int ID { get; set; }
            public static int Count = 0;
            public string Name { get; set; }
            public string Password { get; set; }
            public Adress Adress { get; set; }

            public User(string username, string password)
            {
                // konstruktor / Constructor
                Name = username;
                Password = password;
                Count++;
            }

        public override string ToString()
        {
            return Name + " has password " + Password;
        }

        }      
}
