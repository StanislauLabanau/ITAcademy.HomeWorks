using System;

namespace HW04.Task2
{
    class Program
    {
        const string CORRECT = "correct";
        const string INCORRECT = "incorrect";
        static double EnterDoubleValueConsole()
        {
            double value = 0;
            string valueConsole = default(string);

            do
            {
                if (string.IsNullOrEmpty(valueConsole))
                {
                    Console.WriteLine("enter the value");
                }
                else
                {
                    Console.WriteLine("The format isn't correct, try again");
                }
                valueConsole = Console.ReadLine();
            }
            while (!Double.TryParse(valueConsole, out value));
            return value;
        }

        static double SumOfTwo(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        static string SumOfTwoChecking(double firstValue, double secondValue, double resultValue)
        {
            string answer = INCORRECT;

            if (SumOfTwo(firstValue, secondValue) == resultValue)
            {
                answer = CORRECT;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The first value");
            double valueFirst = EnterDoubleValueConsole();

            Console.WriteLine("The second value");
            double valueSecond = EnterDoubleValueConsole();

            Console.WriteLine("The result of sum");
            double valueResultSum = EnterDoubleValueConsole();

            Console.WriteLine("Your answer is " + SumOfTwoChecking(valueFirst, valueSecond, valueResultSum));
            Console.ReadKey();
        }
    }
}
