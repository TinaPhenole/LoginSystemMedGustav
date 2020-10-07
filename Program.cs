using System;

namespace Enkelt_login_system
{
    class Program
    {
    
        static void Main(string[] args)
        {
            UserAuthentication userAuthentication = new UserAuthentication();


            // Skapade användare och lösenord
            userAuthentication.AddUser("Gustav", "password");
            userAuthentication.AddUser("Phenole", "imaghost");
            userAuthentication.AddUser("Månsson", "onward");

            bool isValidUser = userAuthentication.TryValidateUser("Gustav", "pwd");

            // Skriver ut hur många användare vi har. i detta fallet har vi 3
            Console.WriteLine("User count: " + User.Count);
            // Kontrollerar om användaren och lösenordet fungerar, retunerar en false ifall en av dem inte är korrekt.
            Console.WriteLine("IsValidUser: " + isValidUser);
        }
    }
}
