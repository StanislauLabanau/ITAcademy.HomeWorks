using System;

namespace HW05.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The size of random array");

            long [] randomArray = randomArrayCreationAndShowing(EnterIntConsole());

            Console.WriteLine("The reversed array is");

            arrayRevers(randomArray);

            foreach (int element in randomArray)
            {
                Console.WriteLine(element);
            }

            Console.Read();
        }

        static long[] randomArrayCreationAndShowing(int length)
        {
            Random rnd = new Random();
            long[] randomArray = new long [length];

            Console.WriteLine("The random array is");

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next();
                Console.WriteLine(randomArray[i]);
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

        static void arrayRevers(long [] someArray)
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
