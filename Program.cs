// Do while loop
string password = "";
do
{
    System.Console.WriteLine("Hello, I'm Kescha! To contionue the proccess please enter password");
    password = Console.ReadLine();
}
while(password != "Umid@123");
System.Console.WriteLine("Password entered successful :) ");
Thread.Sleep(2000);

int KeschaAge = 5;
Console.Write("What is your name?  ");

string name = Console.ReadLine();
string greeting = $"Hello, {name}";
Thread.Sleep(2000);
Console.WriteLine(greeting);  
Console.Write("What's your age?  ");
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
    Thread.Sleep(2000);
//Array    
System.Console.WriteLine("Now let me tell you about my friends.");
    Thread.Sleep(2000);
string [] friendsName = {"Luna", "Iris", "Aurora"};
int [] friendsAge = {4,6,5};
string [] fiendsAddress = {"Sydney", "Arizona", "Bangkok"};
System.Console.WriteLine($"One of my friend is {friendsName[0]}. He is from {fiendsAddress[0]} and he is {friendsAge [0]} years old");
}
else if (Confirmation.ToLower() == "no")
{
    System.Console.WriteLine("Okay, no problem");
}

else
{
    Console.WriteLine("Wrong confirmation entered! ");
}