using System;

namespace Csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true) {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guessNumber = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                while (guessNumber != correctNumber)
                {
                    string playerInput = Console.ReadLine();
                    if (!int.TryParse(playerInput, out guessNumber))
                    {
                        PrintColorMessage("Sorry, not a number!", ConsoleColor.Red);
                        continue;
                    }
                    guessNumber = Int32.Parse(playerInput);

                    if (guessNumber != correctNumber)
                    {
                        PrintColorMessage("Wrong number :( Please Try again.", ConsoleColor.Red);
                    }
                }

                PrintColorMessage("Success! You won!", ConsoleColor.Yellow);

                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Christine Groux";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor(); // white
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your Name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Let's play a game, {0}!", playerName);
        }

        static void PrintColorMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor(); // white
        }
    }
}
