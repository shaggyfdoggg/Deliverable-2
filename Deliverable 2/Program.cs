// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.Write("What is your name? ");
string username = Console.ReadLine();
Console.WriteLine($"Welcome {username}. Do you want to do the coin flip challenge? Yes/no");
string answer = Console.ReadLine();
answer = answer.ToUpper();
if (answer == "NO")
{
    Console.WriteLine($"You are a coward, {username}.");
}
else if (answer == "YES")
{
    int score = 0;
    int round = 1;

    for (round = 1, score = 0; round <= 5; round++)
    {
        Random rand = new Random();
        int coin = rand.Next(0, 2);
        Console.WriteLine("Heads or Tails?");
        string choice = Console.ReadLine();
        choice = choice.ToUpper();
        if (choice == "HEADS" && coin == 0)
        {
            score++;
            Console.WriteLine("Correct!");
        }
        else if (choice == "TAILS" && coin == 1)
        {
            score++;
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
    Console.WriteLine($"Thank you, {username}. You got a score of {score}!");
}

