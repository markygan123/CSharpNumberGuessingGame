while (true)
{
    Random random = new Random(); // initialize random
    int randomNumber;
    int attempts;
    int limit;
    int difficulty;
    int guess;
    bool playAgain = true;
    string response;


    Console.WriteLine("\n**********GUESS THE NUMBER GAME**********\n");
    while (true)
    {
        try
        {
            Console.Write("\nEnter the limit number (1-20): ");
            limit = Convert.ToInt32(Console.ReadLine());
            randomNumber = random.Next(1, limit);

            if (limit > 20)
            {
                Console.WriteLine("Please choose a limit number within 1-20.");
            }
            else
            {
                break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number only.");
        }
    }

    while (true)
    {
        Console.Write("\nChoose difficulty: [1) Easy - 20 | [2] Medium - 10 | [3] Hard - 5: ");
        difficulty = Convert.ToInt32(Console.ReadLine());
        if (difficulty == 1)
        {
            attempts = 20;
            break;
        }
        else if (difficulty == 2)
        {
            attempts = 10;
            break;
        }
        else if (difficulty == 3)
        {
            attempts = 5;
            break;
        }
        else
        {
            Console.WriteLine("Please choose among the items listed.");
        }
    }

    randomNumber = random.Next(1, limit);

    while (attempts > 0)
    {
        
        Console.WriteLine($"\nGuess a number between 1 - {limit}: \n");
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess != randomNumber)
        {
            if (guess > 20)
            {
                Console.WriteLine("\nYour guess is past the limit!");
            }

            if (guess <= 20 && guess > randomNumber)
            {
                Console.WriteLine($"\n{guess} is too high!");
            }

            if (guess <= 20 && guess < randomNumber)
            {
                Console.WriteLine($"\n{guess} is too low!");
            }

            

            attempts--;
            Console.WriteLine($"{attempts} guesses left");
        }
        else
        {
            break;
        }
    }

    if (attempts == 0)
    {
        Console.WriteLine($"\nThe random number is {randomNumber}. Better luck next time.");
    }
    else
    {
        Console.WriteLine($"\nCongratulations! You win!");
    }

    Console.Write("\nPlay again? Y/n: ");
    response = Console.ReadLine().ToUpper();

    if (response == "Y")
    {
        playAgain = true;
        Console.Clear();
    }
    else
    {
        break;
    }
}

Console.WriteLine("\nThank you for playing.");

Console.ReadKey();