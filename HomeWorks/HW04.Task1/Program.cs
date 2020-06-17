using System;

namespace HW04.Task1
{
    class Program
    {
        static double EnterDoubleValueConsole()
        {
            double value = 0;
            string valueConsole = default(string);

            do
            {
                if (string.IsNullOrEmpty(valueConsole))
                {
                    Console.WriteLine("enter the value ");
                }
                else
                {
                    Console.WriteLine("The value isn't correct, enter another one");
                }
                valueConsole = Console.ReadLine();
            }
            while (!Double.TryParse(valueConsole, out value));
            return value;
        }

        static void SummOfTwo(double firstValue, double secondValue)
        {
            Console.WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The first value");
            double valueFirst = EnterDoubleValueConsole();

            Console.WriteLine("The second value");
            double valueSecond = EnterDoubleValueConsole();
            
            SummOfTwo(valueFirst, valueSecond);

            Console.ReadKey();
        }
    }
}
