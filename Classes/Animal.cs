using System;

namespace KESCHA.Classes
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }
        
        public Animal(int animalAge, string animalName)
        {
            AnimalAge = animalAge;
            AnimalName = animalName;
        }

        public void CompareAgeWithUser(int userAge, string userName, string userPlace)
        {
            // Compare age with user's age
            Console.WriteLine($"Do you want to compare your age with {AnimalName}'s age?");
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
                System.Threading.Thread.Sleep(2000);

                // Calculate and display age difference between user and Kescha
                int ageDifference = userAge - AnimalAge;
                Console.WriteLine($"The age difference between you and {AnimalName} is: {ageDifference} years.");

                if (userAge > AnimalAge)
                {
                    Console.WriteLine($"You are older than {AnimalName}.");
                }
                else if (userAge == AnimalAge)
                {
                    Console.WriteLine($"You are the same age as {AnimalName}.");
                }
                else
                {
                    Console.WriteLine($"You are younger than {AnimalName}.");
                }
                Thread.Sleep(3000);
            }
            else if (confirmation == "no")
            {
                Console.WriteLine("Okay, no problem.");
                Thread.Sleep(3000);
            }
        }
    }
}