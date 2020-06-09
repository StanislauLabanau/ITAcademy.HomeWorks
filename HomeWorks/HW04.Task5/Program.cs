using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string alfabetStr = "ABCDEFG";
            char mediator;

            char[] alfabet = alfabetStr.ToCharArray();

            for (int i = 0; i < alfabet.Length; i++)
            {
                mediator = alfabet[i];
                alfabet[i] = alfabet[alfabet.Length - 1 - i];
                alfabet[alfabet.Length - 1 - i] = mediator;
            }

            for (int i = 0; i < alfabet.Length; i++)
            {
                Console.WriteLine(alfabet[i]);
            }
        }
    }
}
