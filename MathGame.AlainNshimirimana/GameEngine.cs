﻿

namespace MathGame.AlainNshimirimana
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Addition");
        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Subtraction");
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type any key for the next question");
                    score++;

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, "Division");

        }
    }
}
