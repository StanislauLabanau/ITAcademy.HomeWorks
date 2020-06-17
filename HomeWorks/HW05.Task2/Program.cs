using System;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)

        {
            int arraySize = default(int);
            int newElementValue = default(int);
            int newElementPosition = default(int);

            Console.WriteLine("The array size initialisation");
            arraySize = EnterIntConsole();

            int[] arrayIncomplete = new int[] { };
           
            Array.Resize(ref arrayIncomplete, arraySize);

            for (int i = 0; i < arrayIncomplete.Length-1; i++)
            {
                Console.WriteLine($"the {i} element of the array initialisation");
                arrayIncomplete[i] = EnterIntConsole();
            }

            Console.WriteLine("The entered array is");

            foreach (int element in arrayIncomplete)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("The new element initialisation");
            newElementValue = EnterIntConsole();

            Console.WriteLine("The position, the new element should be placed");
            newElementPosition = EnterPositionConsole(arraySize);

            for (int i = arrayIncomplete.Length-1; i > newElementPosition; i--)
            {
                arrayIncomplete[i] = arrayIncomplete[i - 1];
            }

            arrayIncomplete[newElementPosition] = newElementValue;

            Console.WriteLine("The completed array is");

            foreach (int element in arrayIncomplete)
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

        static int EnterPositionConsole(int arraySize)
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
            while (!(int.TryParse(defaultValueConsole, out value) && value>=0 && value<arraySize));

            return value;
        }
    }

}
