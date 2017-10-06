using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string rePlay = "";

            do
            {
                //Lucky Numbers Part 1


                Console.WriteLine("Hello and welcome to the Lucky Numbers Lottery Game!");
                Console.WriteLine("Please enter the starting number for the first number in your guessing range");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Great, now enter the end number in your guessing range");
                Console.WriteLine("This number can not be less than your first number!");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Now, you must guess 6 random numbers within the range that you picked");



                int[] guessedNumbers = new int[6];
                for (int i = 0; i < guessedNumbers.Length; i++)
                {
                    guessedNumbers[i] = int.Parse(Console.ReadLine());

                    if (guessedNumbers[i] > secondNumber)
                    {
                        Console.WriteLine("Please enter a valid number");
                        continue;
                    }
                    else if (guessedNumbers[i] < firstNumber)
                    {
                        Console.WriteLine("Please enter a valid number");
                        continue;
                    }

                }

                // Part 2


                // hard code for jackpot to be used later
                double jackpot = 1000;

                Console.WriteLine("Now... I am going to guess 6 random numbers within the range you chose.");
                Console.WriteLine("If you guessed all 6 correctly, you could win " + jackpot);
                Console.WriteLine("You will get a portion of the jackpot based on how many numbers you guess");
                Console.WriteLine("correctly");



                int[] computerNumbers = new int[6];
                Random rand = new Random();
                for (int number = 0; number < 6; number++)
                {
                    int randomNumber = rand.Next(firstNumber, secondNumber) + 1;
                    computerNumbers[number] = randomNumber;
                    Console.WriteLine("Lucky number: " + computerNumbers[number]);
                }

                // 'Contains' - if computerNumbers CONTAINS guessed numbers than it will count the correct numbers by one(++)

                int correctGuess = 0;
                double moneyWon = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (computerNumbers.Contains(guessedNumbers[i]))
                    {
                        correctGuess++;

                    }
                }

                Console.WriteLine("You guessed " + correctGuess + " correct numbers!!");

                moneyWon = correctGuess * (jackpot / 6);
                Console.WriteLine("You have won $ " + moneyWon);
                Console.WriteLine("Would you like to play again? YES/NO");
                rePlay = Console.ReadLine().ToUpper();


            }

            while (rePlay == "YES");





                       





















        }
    }
}
