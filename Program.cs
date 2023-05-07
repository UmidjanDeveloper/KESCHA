using System;
using System.Threading;
using KESCHA.Classes;

namespace KESCHA
{
      public class Program
    {
        static void Main()
        {
            // Create instance of Security class and check password
            Security security = new Security();
            security.CheckPassword();

            // Greet user and ask for their name and age
            string userName;
            int userAge;
            string userPlace;
            User.GetUserInputs(out userName, out userAge, out userPlace);

            // Create instance of User and Animal classes
            User user = new User(userName, userAge, userPlace);
            Animal kescha = new Animal(animalAge: 3, animalName: "Kescha");

            // Compare age with user's age
            kescha.CompareAgeWithUser(user.UserAge,user.UserName, user.userPlace);

            // Introduce Kescha's friends 
            Friends.IntroduceFriends(userAge, userName, userPlace);
        }
    }
}