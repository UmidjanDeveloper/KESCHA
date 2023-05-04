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

            // Greet user and ask for their name
            Console.Write("What is your name?  ");
            string name = Console.ReadLine();
            string greeting = $"Hello, {name}";
            Thread.Sleep(2000);
            Console.WriteLine(greeting);

            // Ask for user's age
            Console.Write("What's your age?  ");
            int age = int.Parse(Console.ReadLine());
            Thread.Sleep(2000);
            string greeting2 = $"That's awesome, {name}. Nice to meet you.";
            Console.WriteLine(greeting2);
            Thread.Sleep(2000);

            // Compare user's age with Kescha's age
            Console.WriteLine("Do you want to compare your age with Kescha's age?");
            string confirmation = Console.ReadLine().ToLower();
            Thread.Sleep(2000);

            if (confirmation == "yes")
            {
                Console.WriteLine("Wait......");
                Thread.Sleep(2000);
                int keschaAge = 5;
                int ageDifference = age - keschaAge;
                Console.WriteLine($"The result is: {ageDifference}");

                if (age > keschaAge)
                {
                    Console.WriteLine("You are older than Kescha.");
                }
                else if (age == keschaAge)
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

                string[] friendsName = {"Luna", "Iris", "Aurora"};
                int[] friendsAge = {4, 6, 5};
                string[] friendsAddress = {"Sydney", "Arizona", "Bangkok"};

                for (int i = 0; i < friendsName.Length; i++)
                {
                    Console.WriteLine($"One of my friends is {friendsName[i]}. He is from {friendsAddress[i]} and he is {friendsAge[i]} years old");
                }
            }
            else if (confirmation == "no")
            {
                Console.WriteLine("Okay, no problem");
            }
            else
            {
                Console.WriteLine("Wrong confirmation entered!");
            }
        }
    }
}
