using System;
using System.Threading;
using KESCHA.Classes;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            // Create instance of Security class and check password
            Security security = new Security();
            security.CheckPassword();

            // Greet user and ask for their name and age
            string userName;
            int userAge;
            User.GetUserInputs(out userName, out userAge);

            // Create instance of Kescha and compare age with user's age
            Animal kescha = new Animal(animalAge: 3, animalName: "Kescha");
            Console.WriteLine("Do you want to compare your age with Kescha's age?");
            
            // Validate user confirmation input
            string confirmation;
            do
            {
                confirmation = Console.ReadLine().ToLower();
                if (confirmation != "yes" && confirmation != "no")
                {
                    Console.WriteLine("Wrong confirmation entered! Please enter 'yes' or 'no'.");
                }
            } while (confirmation != "yes" && confirmation != "no");

            if (confirmation == "yes")
            {
                Console.WriteLine("Wait......");
                Thread.Sleep(2000);

                // Calculate and display age difference between user and Kescha
                kescha.AgeDifference = userAge - kescha.animalAge;
                Console.WriteLine($"The age difference between you and Kescha is: {kescha.AgeDifference} years.");

                if (userAge > kescha.animalAge)
                {
                    Console.WriteLine("You are older than Kescha.");
                }
                else if (userAge == kescha.animalAge)
                {
                    Console.WriteLine("You are the same age as Kescha.");
                }
                else
                {
                    Console.WriteLine("You are younger than Kescha.");
                }

                Thread.Sleep(2000);

                // Display Kescha's friends' details
                Console.WriteLine("Now let me tell you about my friends.");
                Thread.Sleep(2000);

                string[] friendsName = { "Luna", "Iris", "Aurora", userName };
                int[] friendsAge = { 4, 6, 5, userAge };
                string[] friendsAddress = { "Sydney", "Arizona", "Bangkok", "Actually you didn't tell yet" };

                for (int i = 0; i < friendsName.Length; i++)
                {
                    Console.WriteLine($"One of my friends is {friendsName[i]}. He is from {friendsAddress[i]} and he is {friendsAge[i]} years old.");
                }
            }
            else if (confirmation == "no")
            {
                Console.WriteLine("Okay, no problem.");
            }
        }
    }
} 
