using System;

namespace Enkelt_login_system
{
    class Program
    {
    
        static void Main(string[] args)
        {
            UserAuthentication userAuthentication = new UserAuthentication();

            userAuthentication.AddUser("Gustav", "password");
            userAuthentication.AddUser("Phenole", "imaghost");
            userAuthentication.AddUser("Månsson", "onward");

            bool isValidUser = userAuthentication.TryValidateUser("Gustav", "pwd");

            Console.WriteLine("IsValidUser: " + isValidUser);
        }
    }
}
