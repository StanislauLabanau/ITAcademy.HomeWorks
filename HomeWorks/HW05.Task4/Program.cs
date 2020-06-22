using System;
using System.Diagnostics;

namespace HW05.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The size of random array");

            long[] randomArray1 = randomArrayCreation(EnterIntConsole());
            long[] randomArray2 = randomArray1;
            Stopwatch timer = new Stopwatch();

            timer.Start();
            arrayRevers(randomArray1);
            timer.Stop();
            Console.WriteLine("The time of my revers array method execution is " + timer.ElapsedMilliseconds);

            timer.Reset();
            timer.Start();
            Array.Reverse(randomArray2);
            timer.Stop();
            Console.WriteLine("The time of standart array revers method execution is " + timer.ElapsedMilliseconds);

            Console.Read();
        }

        static long[] randomArrayCreation(int length)
        {
            Random rnd = new Random();
            long[] randomArray = new long[length];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next();
            }

            return randomArray;
        }

        static int EnterIntConsole()
        {
            string defaultValueConsole = string.Empty;
            int value = default(int);

            do
            {
                if (string.IsNullOrEmpty(defaultValueConsole))
                {
                    Console.WriteLine("enter the value");
                }
                else
                {
                    Console.WriteLine("incorrect format, try again");
                }
                defaultValueConsole = Console.ReadLine();
            }
            while (!int.TryParse(defaultValueConsole, out value));

            return value;
        }

        static void arrayRevers(long[] someArray)
        {
            int arrayLastElementNumber = someArray.Length - 1;
            int arrayMiddle = someArray.Length / 2;
            long mediator = default(int);

            for (int i = arrayLastElementNumber; i >= arrayMiddle; i--)
            {
                mediator = someArray[i];
                someArray[i] = someArray[arrayLastElementNumber - i];
                someArray[arrayLastElementNumber - i] = mediator;
            }
        }
    }
}
