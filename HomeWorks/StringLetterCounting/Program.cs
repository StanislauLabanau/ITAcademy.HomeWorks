using System;
using System.Linq;
using System.Text;

namespace StringLetterCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string someString = Console.ReadLine();
            StringBuilder resultString = GetSortedString(someString);

            Console.WriteLine($"The result string is \n{resultString}");
            Console.ReadKey();
        }
        static StringBuilder GetSortedString(string someString)
        {
            const char FirstLetter = 'a';
            const char LastLetter = 'z';
            char minLetter = LastLetter;
            int letterCounter = 0;

            someString = someString.ToLower();

            StringBuilder sb = new StringBuilder(someString);
            StringBuilder resultSb = new StringBuilder();

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] < FirstLetter || sb[i] > LastLetter)
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }

            while (sb.Length != 0)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] < minLetter)
                    {
                        minLetter = sb[i];
                    }
                }

                letterCounter = sb.Length - sb.Replace(minLetter.ToString(), "").Length;
                resultSb.Append(minLetter);
                resultSb.Append(letterCounter);

                letterCounter = 0;
                minLetter = LastLetter;
            }

            return resultSb;
        }
    }
}
