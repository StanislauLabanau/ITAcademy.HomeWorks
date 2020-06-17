using System;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)

        {
            int arraySize = default(int);
            Console.WriteLine("Array size ");
            arraySize = EnterIntConsole();

            int[] arrayConsole = new int[] { };
            int[] arrayRandom = new int[] { };
            int[] arraySum = new int[] { };

            Array.Resize(ref arrayConsole, arraySize);
            Array.Resize(ref arrayRandom, arraySize);
            Array.Resize(ref arraySum, arraySize);

            Random rnd = new Random();

            for (int i=0; i<arrayConsole.Length; i++)
            {
                Console.WriteLine($"{i} element of the array");
                arrayConsole[i] = EnterIntConsole();
                arrayRandom[i] = rnd.Next(1, 10);
                arraySum[i] = arrayConsole[i] + arrayRandom[i];
            }

            Console.WriteLine("Entered array");

            foreach (int element in arrayConsole)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Random array");

            foreach (int element in arrayRandom)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Entered + random array");

            foreach (int element in arraySum)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
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
    }
}
