using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
        private int numberToGuess = 0;
        int userGuess = 0;
        int minimum = 0;
        int maximum = 0;

        public NumberGuessing(int minimum, int maximum)
        {
            GenerateRandomNumber(minimum, maximum);
        }

        public void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(minimum, maximum);

            this.minimum = minimum;
            this.maximum = maximum;
        }

        public GuessResult MakeGuess (int guess)
        {
<<<<<<< HEAD
            if (guess > maximum || guess <   minimum)
=======
            if (guess > maximum || guess < minimum)
>>>>>>> 9a46a08306706be9ef10d393b4b1a32e4a465812
            {
                return GuessResult.OutOfLimits;
            }
            else if (guess == numberToGuess)
            {
                GuessResult result = GuessResult.Correct;

                return result;
            }
            else if(guess < numberToGuess) 
            {
                return GuessResult.TooLow;
            }
            else
            {
                return GuessResult.TooHigh;
            }
        }
    }
}
