using System;

namespace HW03.Task1
{
    class Calculator
    {
        public double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        public double Subtruct(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        public double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        public double Devide(double firstValue, double secondValue)
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
        public int ReminderAfterDeviding(int devident, int devider)
        {
            return devident % devider;
        }
        public double CircleSquare(double Radius)
        {
            return 3.14 * Radius * Radius;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            //create variables that should be calculated
            double firstValue;
            double secondValue;
            double radius;
            int devident;
            int devider;
            //create object of Calculator class for ability of using it's methods 
            Calculator calculator = new Calculator();
            //consol initialisation of variables and checking for proper enter 
            //the first value for common calculations
            link1:
            Console.WriteLine("Please, enter the first value for common calculations");
            string firstValueConsole = Console.ReadLine();
            if (Double.TryParse(firstValueConsole, out firstValue))
            {
                Console.WriteLine("The first value have been set \n");
            }
            else
            {
                Console.WriteLine("The value is not correct, try to enter another");
                goto link1;
            }
            //the second value for common calculations
            link2:
            Console.WriteLine("Please, enter the second value for common calculations");
            string secondValueConsole = Console.ReadLine();
            if (Double.TryParse(secondValueConsole, out secondValue))
            {
                Console.WriteLine("The second value have been set \n");
            }
            else
            {
                Console.WriteLine("The value is not correct, try to enter another");
                goto link2;
            }
            //the circle radius value
            link3:
            Console.WriteLine("Please, enter the circle radius");
            string radiusConsole = Console.ReadLine();
            if (Double.TryParse(radiusConsole, out radius))
            {
                Console.WriteLine("The circle radius have been set \n");
            }
            else
            {
                Console.WriteLine("The value is not correct, try to enter another");
                goto link3;
            }
            //the devident and the devider values (for the reminder after devision calculation)
            link4:
            Console.WriteLine("Please, enter the value for devident");
            string devidentConsole = Console.ReadLine();
            if (Int32.TryParse(devidentConsole, out devident))
            {
                Console.WriteLine("The devident have been set \n");
            }
            else
            {
                Console.WriteLine("The value is not correct, try to enter another");
                goto link4;
            }
            link5:
            Console.WriteLine("Please, enter the value for devider");
            string deviderConsole = Console.ReadLine();
            if (Int32.TryParse(deviderConsole, out devider) && devider!=0)
            {
                Console.WriteLine("The devider have been set \n");
            }
            else
            {
                Console.WriteLine("The value is not correct, try to enter another");
                goto link5;
            }
            Console.WriteLine($"The result of calculations {firstValue} and {secondValue}");
            Console.WriteLine("Add: " + calculator.Add(firstValue, secondValue));
            Console.WriteLine("Substrut: " + calculator.Subtruct(firstValue, secondValue));
            Console.WriteLine("Multiply: " + calculator.Multiply(firstValue, secondValue));
            Console.WriteLine("Devide: " + calculator.Devide(firstValue, secondValue));
            Console.WriteLine($"The squere of cicle with radius {radius} is {calculator.CircleSquare(radius)}");
            Console.WriteLine($"The reminder after devision of {devident} by {devider} is {calculator.ReminderAfterDeviding(devident, devider)}");
            Console.ReadKey();
        }
    }
}
