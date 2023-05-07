namespace KESCHA.Classes
{
    public class User
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string userPlace { get; set; }
        public User(string userName, int userAge, string userPlace)
        {
            UserName = userName;
            UserAge = userAge;
            this.userPlace = userPlace;
        }

        public static void GetUserInputs(out string userName, out int userAge,out string userPlace)
        {
            Console.Write("What is your name?  ");
            userName = Console.ReadLine();
            string greeting = $"Hello, {userName}";
            Thread.Sleep(2000);
            Console.WriteLine(greeting);

            Thread.Sleep(1000);
             System.Console.Write("Where are you from?  ");
             userPlace = Console.ReadLine();

            Thread.Sleep(1000);
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
