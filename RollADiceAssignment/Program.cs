Random random = new Random();
var _valid = new IsValid();
int randomNumber = random.Next(1, 7);
Console.WriteLine("Dice Rolled. Guess what number it shows. You only have 3 tries.");
int tries = 0;
bool guessedCorrectly = false;


while (tries < 3 && !guessedCorrectly)
{
    Console.Write("Enter your guess: ");
    var inputNum = Console.ReadLine();

    if (IsValid.CheckIfInt(inputNum, out int guessedNumber))
    {
        if (guessedNumber == randomNumber)
        {
            Console.WriteLine("Congratulations! You guessed the correct number.");
            guessedCorrectly = true;
        }
        else
        {
            Console.WriteLine("Wrong guess. Try again.");
            tries++;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
    }
}

if (!guessedCorrectly)
{
    Console.WriteLine("Sorry, you've used all your tries. The correct number was " + randomNumber);
}

Console.ReadKey();


