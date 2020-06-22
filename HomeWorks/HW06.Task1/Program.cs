using System;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string replaceable1 = "o";
            string replacement1 = "a";
            string replaceable2 = "O";
            string replacement2 = "A";

            Console.WriteLine("Enter the verse in line, using semicolon between lines");
            string inLineVerse = Console.ReadLine();

            string[] linesOfVerse = inLineVerse.Split(';');

            if (inLineVerse.Contains(replaceable1) || inLineVerse.Contains(replaceable2))
            {
                Console.WriteLine("The transformed verse is:");
                for (int i = 0; i < linesOfVerse.Length; i++)
                {
                    linesOfVerse[i] = linesOfVerse[i].Replace(replaceable1, replacement1);
                    linesOfVerse[i] = linesOfVerse[i].Replace(replaceable2, replacement2);
                }
            }
            else
            {
                Console.WriteLine($"The verse has neither {replaceable1} nor {replaceable2}");
            }

            foreach (string elements in linesOfVerse)
            {
                Console.WriteLine(elements);
            }

            Console.ReadKey();
        }
    }
}
