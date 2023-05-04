using System;

namespace KESCHA.Classes
{
    public class Security
    {
        public void CheckPassword()
        {
            string password = "";
            do
            {   
                Console.WriteLine("Hello, I'm Kescha! To continue the process please enter password:");
                password = Console.ReadLine();
                if(password != "Umid@123")
                {
                    Console.WriteLine("Incorrect password, please try again.");
                }
            } while(password != "Umid@123");

            Console.WriteLine("Password entered successfully :) ");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
