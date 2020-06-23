using System;
using System.Linq;
using System.Text;

namespace StringLetterCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string someString = Console.ReadLine();

            Console.WriteLine($"The result string is \n{GetSortedString(someString)}");

            Console.ReadKey();
        }
        static StringBuilder GetSortedString(string someString)
        {
            const char firstLetter = 'a';
            const char lastLetter = 'z';
            char min;
            int counter;

            someString = someString.ToLower();

            StringBuilder sb = new StringBuilder(someString);
            StringBuilder resultSb = new StringBuilder();

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] < firstLetter || sb[i] > lastLetter)
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }

            while (sb.Length != 0)
            {
                counter = 0;
                min = lastLetter;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] <= min)
                    {
                        min = sb[i];
                    }
                }
                counter = 0;
                counter = sb.Length - sb.Replace(min.ToString(), "").Length;
                resultSb.Append(min);
                resultSb.Append(counter);
            }

            return resultSb;
        }
    }
}
