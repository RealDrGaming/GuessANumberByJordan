bool playAgain = false;

do
{
    Console.WriteLine("Input the ranges of the game in the format {lowerRange - upperRange}, ex. {1-100}");

    string input = Console.ReadLine();
    string[] inputs = input.Split('-');
    int lowerRange = int.Parse(inputs[0]);
    int upperRange = int.Parse(inputs[1]);

    Random randomNumber = new Random();
    int computerNumber = randomNumber.Next(lowerRange, upperRange - 1);

    while (true)
    {
        Console.Write($"Guess the computer's number {lowerRange}-{upperRange}: ");
        string playerInput = Console.ReadLine();
        bool isValid = int.TryParse(playerInput, out int playerNumber);

        if (isValid)
        {
            if (playerNumber == computerNumber)
            {
                Console.WriteLine("You guessed it! Wanna play again? yes/no");

                string playAgainString = Console.ReadLine();

                if (playAgainString.ToLower() == "y" || playAgainString.ToLower() == "yes") playAgain = true;
                else if (playAgainString.ToLower().ToLower() == "n" || playAgainString.ToLower() == "no") playAgain = false;
                else Console.WriteLine("Couldn't get that. Ending game.");

                break;
            }
            else if (playerNumber > computerNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else if (playerNumber < computerNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
} while (playAgain);