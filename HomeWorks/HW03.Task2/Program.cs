using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables that should be calculated and their default initialisation 
            double firstValue = 1;
            double secondValue = 1;
            double radius = 1;
            int devident = 1;
            int devider = 1;

            string firstValueConsole = "";
            string secondValueConsole = "";
            string radiusConsole = "";
            string devidentConsole = "";
            string deviderConsole = "";

            //consol initialisation of variables and checking for proper enter 
            //the first value for common calculations
            do
            {
                if (string.IsNullOrEmpty(firstValueConsole))
                {
                    Console.WriteLine("Please, enter the first value for common calculations");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                firstValueConsole = Console.ReadLine();
            }
            while (!Double.TryParse(firstValueConsole, out firstValue));

            //the second value for common calculations
            do
            {
                if (string.IsNullOrEmpty(secondValueConsole))
                {
                    Console.WriteLine("Please, enter the second value for common calculations");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                secondValueConsole = Console.ReadLine();
            }
            while (!Double.TryParse(secondValueConsole, out secondValue));

            //the circle radius value
            do
            {
                if (string.IsNullOrEmpty(radiusConsole))
                {
                    Console.WriteLine("Please, enter the circle radius value");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                radiusConsole = Console.ReadLine();
            }
            while (!Double.TryParse(radiusConsole, out radius));

            //the devident values (for the reminder after devision calculation)
            do
            {
                if (string.IsNullOrEmpty(devidentConsole))
                {
                    Console.WriteLine("Please, enter the devident value");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                devidentConsole = Console.ReadLine();
            }
            while (!Int32.TryParse(devidentConsole, out devident));

            //the devider values (for the reminder after devision calculation)
            do
            {
                if (string.IsNullOrEmpty(deviderConsole))
                {
                    Console.WriteLine("Please, enter the devider value");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                deviderConsole = Console.ReadLine();
            }
            while (!Int32.TryParse(deviderConsole, out devider) || devider == 0);
            Console.WriteLine($"The result of calculations {firstValue} and {secondValue}");
            Console.WriteLine("Add: " + Add(firstValue, secondValue));
            Console.WriteLine("Substrut: " + Subtruct(firstValue, secondValue));
            Console.WriteLine("Multiply: " + Multiply(firstValue, secondValue));
            Console.WriteLine("Devide: " + Devide(firstValue, secondValue));
            Console.WriteLine($"The squere of cicle with radius {radius} is {CircleSquare(radius)}");
            Console.WriteLine($"The reminder after devision of {devident} by {devider} is {ReminderAfterDeviding(devident, devider)}");
            Console.ReadKey();
        }
        static double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        static double Subtruct(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        static double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        static double Devide(double firstValue, double secondValue)
        {

            if (secondValue == 0)
            {
                Console.WriteLine("The second value is set to zero, it's impossible to devide by zero");
                return firstValue / secondValue;
            }
            else
            {
                return firstValue / secondValue;
            }
        }
        static int ReminderAfterDeviding(int devident, int devider)
        {
            return devident % devider;
        }
        static double CircleSquare(double Radius)
        {
            return 3.14 * Radius * Radius;
        }
    }
}
