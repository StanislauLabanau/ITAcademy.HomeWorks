using System;

namespace HW04.Task3
{
    class Program
    {
        const string CORRECT = "correct";
        const string INCORRECT = "incorrect";
        const string MORE = ", the correct number is more";
        const string LESS = ", the correct number is less";
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

        static string SumOfTwoCheckingWithPrompt(double firstValue, double secondValue, double resultValue)
        {
            string answer = CORRECT;
            double resultSumOfTwo = SumOfTwo(firstValue, secondValue);

            if (resultSumOfTwo > resultValue)
            {
                answer = INCORRECT+MORE;
            }
            if (resultSumOfTwo < resultValue)
            {
                answer = INCORRECT + LESS;
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

            Console.WriteLine("Your answer is " + SumOfTwoCheckingWithPrompt(valueFirst, valueSecond, valueResultSum));
            Console.ReadKey();
        }
    }
}
