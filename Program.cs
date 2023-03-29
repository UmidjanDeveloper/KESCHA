int KeschaAge = 5;
Console.WriteLine("What is your name?");

string name = Console.ReadLine();
string greeting = $"Hello, {name}";
Thread.Sleep(2000);
Console.WriteLine(greeting);  
Console.WriteLine("What's your age?");
string AgeString = Console.ReadLine();
int Age = int.Parse(AgeString);
Thread.Sleep(2000);
string greeting2 = $"That's awesome, {name}. Nice to meet you.";
Console.WriteLine(greeting2);
Thread.Sleep(2000);
Console.WriteLine("Do you want to compare your age with Kescha's age?");
string Confirmation = Console.ReadLine();
Thread.Sleep(2000);

if (Confirmation.ToLower() == "yes")
{
    Console.WriteLine("Wait......");
    Thread.Sleep(2000);
    Console.WriteLine($"The result is: {Age - KeschaAge}");
    if (Age > KeschaAge)
    {
        Console.WriteLine("You are older than Kescha.");
    }
    else if (Age == KeschaAge)
    {
        Console.WriteLine("You are the same age as Kescha.");
    }
    else
    {
        Console.WriteLine("You are younger than Kescha.");
    }
}
else
{
    Console.WriteLine("Okay, no problem.");
}

// Console.WriteLine($"And you are older than Kescha {Age > KeschaAge}");
// Console.WriteLine($"And you are younger than Kescha {Age > KeschaAge}");
// Console.WriteLine($"And you are younger than Kescha {Age == KeschaAge}") 