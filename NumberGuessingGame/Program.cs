namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            Console.WriteLine("What level do you want to play (E), (M) or(H)");
            string difficulty = Console.ReadLine();

            if(difficulty == "E")
            {
                maximum = 10;
            }
            else if (difficulty == "M")
            {
                maximum = 50;
            }
            else if (difficulty == "H")
            {
                maximum = 100;
            }

            NumberGuessing numberGuessing = new NumberGuessing(1, maximum);

            bool guessed = false;

            while(!guessed)
            {
                Console.WriteLine("Please enter your guess:");
                string guess = Console.ReadLine();
                GuessResult result = numberGuessing.MakeGuess(int.Parse(guess));

                if (result == GuessResult.TooLow)
                {
                    Console.WriteLine("Your guess is too Low!!  Please try again");
                }
                else if (result == GuessResult.TooHigh)
                {
                    Console.WriteLine("Your guess is too High!!  Please try again");
                }
                else if (result == GuessResult.Correct)
                {
                    Console.WriteLine("Well Done!! You are correct.");
                    guessed = true;
                }
                else if (result == GuessResult.OutOfLimits)
                {
                    Console.WriteLine("This is out of range!!! Are you kidding!!??");
                }
            }
        }
    }
}
