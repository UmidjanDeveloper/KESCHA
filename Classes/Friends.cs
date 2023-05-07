using System;
using KESCHA.Classes;
 namespace KESCHA.Classes
 {
    public class Friends
{
    public static void IntroduceFriends(int userAge, string userName, string userPlace)
    {
        Console.WriteLine("Do you want me to tell you about my friends? ");
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
                 string[] friendsName = { "Luna", "Iris", "Aurora", userName };
                int[] friendsAge = { 4, 6, 5, userAge };
                string[] friendsAddress = { "Sydney", "Arizona", "Bangkok", userPlace};

            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"One of my friends is {friendsName[i]}. He is from {friendsAddress[i]} and he is {friendsAge[i]} years old.");
            }
            }
            else
            {
                System.Console.WriteLine("Okay, that's your choice :)");
            }
    }
}
}