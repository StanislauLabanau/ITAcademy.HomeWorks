using System;

namespace HW04.Task4
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

        static char EnterOperatorConsole()
        {
            char value = default(char);
            string valueConsole = default(string);

            do
            {
                if (string.IsNullOrEmpty(valueConsole))
                {
                    Console.WriteLine("enter the operator + or - ");
                }
                else
                {
                    Console.WriteLine("The format isn't correct, try again");
                }
                valueConsole = Console.ReadLine();
            }
            while (!Char.TryParse(valueConsole, out value) && (value =='+' || value=='-'));
            return value;
        }

        static double OperationOfTwo(double firstValue, double secondValue, char operator_)
        {
            double result = firstValue + secondValue;

            if (operator_=='-')
            {
                result = firstValue - secondValue;
            }

            return result;
        }

        static string OperationOfTwoCheckingWithPrompt(double firstValue, double secondValue, char operator_, double resultValue)
        {
            string answer = CORRECT;
            double resultOperationOfTwo = OperationOfTwo(firstValue, secondValue, operator_);

            if (resultOperationOfTwo > resultValue)
            {
                answer = INCORRECT + MORE;
            }
            else if (resultOperationOfTwo < resultValue)
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

            Console.WriteLine("The operation");
            char operator_ = EnterOperatorConsole();

            Console.WriteLine("The result of operation");
            double valueResultSum = EnterDoubleValueConsole();

            Console.WriteLine("Your answer is " + OperationOfTwoCheckingWithPrompt(valueFirst, valueSecond, operator_, valueResultSum));
            Console.ReadKey();
        }
    }
}
