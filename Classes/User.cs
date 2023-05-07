namespace KESCHA.Classes
{
    public class User
    {
        public static void GetUserInputs(out string userName, out int userAge)
        {
            Console.Write("What is your name?  ");
            userName = Console.ReadLine();
            string greeting = $"Hello, {userName}";
            Thread.Sleep(2000);
            Console.WriteLine(greeting);

            Console.Write("What's your age?  ");
            string ageString = Console.ReadLine();
            userAge = int.Parse(ageString);
            Thread.Sleep(2000);
            string greeting2 = $"That's awesome, {userName}. Nice to meet you.";
            Console.WriteLine(greeting2);
            Thread.Sleep(2000);
        }
    }
}
