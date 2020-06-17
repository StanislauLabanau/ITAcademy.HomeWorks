using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //array revers
            string alphabetStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabet = alphabetStr.ToCharArray();
            char mediator;

            for (int i = 0; i < alphabet.Length / 2; i++)
            {
                mediator = alphabet[alphabet.Length - 1 - i];
                alphabet[alphabet.Length - 1 - i] = alphabet[i];
                alphabet[i] = mediator;
            }

            foreach (char symbols in alphabet)
            {
                Console.WriteLine(symbols);
            }

            //task 5 
            for (int i=90; i>64; i--)
            {
                Console.Write(" " + (char)i);
            }
            Console.ReadKey();
        }
    }
}
