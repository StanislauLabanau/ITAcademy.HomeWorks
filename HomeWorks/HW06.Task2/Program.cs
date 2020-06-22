using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string myString = Console.ReadLine();

            int[] quantitySymbolsPunktuationLetters = GetlettersAndPunktuationMarksQuantity(myString);

            Console.WriteLine("The string without the longest word is \n" + GetWithoutLongestWord(myString));

            Console.WriteLine("The string with longest and shortest word swiped is \n" + GetSwappedLongestShortestWord(myString));

            Console.WriteLine($"The string has {quantitySymbolsPunktuationLetters[1]} letters and {quantitySymbolsPunktuationLetters[2]} punctuation marks");

            Console.WriteLine("The sorted from the longest to the shortest word string array is ");
            SortWordsLongestShortest(myString);

            Console.ReadLine();
        }

        static string GetWithoutLongestWord(string anyString)
        {
            string longestWord = string.Empty;

            string[] anyStringArray = anyString.Split(' ');

            for (int i = 0; i < anyStringArray.Length; i++)
            {
                if (longestWord.Length < anyStringArray[i].Length)
                {
                    longestWord = anyStringArray[i];
                }
            }

            if (longestWord == anyStringArray[anyStringArray.Length - 1])
            {
                anyString = anyString.Replace(longestWord, "");
            }
            else
            {
                anyString = anyString.Replace(longestWord + " ", "");
            }
            return anyString;
        }

        static string GetSwappedLongestShortestWord(string anyString)
        {
            string longestWord = string.Empty;
            int indexOfLongestWord = default(int);
            int indexOfShortestWord = default(int);

            string[] anyStringArray = anyString.Split(' ');
            string shortestWord = anyStringArray[0];

            for (int i = 0; i < anyStringArray.Length; i++)
            {
                if (longestWord.Length < anyStringArray[i].Length)
                {
                    longestWord = anyStringArray[i];
                    indexOfLongestWord = i;
                }

                if (shortestWord.Length > anyStringArray[i].Length)
                {
                    shortestWord = anyStringArray[i];
                    indexOfShortestWord = i;
                }
            }

            anyStringArray[indexOfLongestWord] = shortestWord;
            anyStringArray[indexOfShortestWord] = longestWord;

            anyString = string.Empty;

            for (int i = 0; i < anyStringArray.Length - 1; i++)
            {
                anyString += anyStringArray[i] + " ";
            }
            anyString += anyStringArray[anyStringArray.Length - 1];
            return anyString;
        }

        static int[] GetlettersAndPunktuationMarksQuantity(string anyString)
        {
            int[] resultSymbolsPunktuationLetters = new int[3] { default(int), default(int), default(int) };

            string[] anyStringArray = anyString.Split(' ');

            for (int i = 0; i < anyStringArray.Length; i++)
            {
                resultSymbolsPunktuationLetters[0] += anyStringArray[i].Length;
                if (anyStringArray[i].Contains(",") || anyStringArray[i].Contains(".") || anyStringArray[i].Contains(":")
                    || anyStringArray[i].Contains(";") || anyStringArray[i].Contains("!") || anyStringArray[i].Contains("?"))
                {
                    resultSymbolsPunktuationLetters[2]++;
                }
            }
            resultSymbolsPunktuationLetters[1] = resultSymbolsPunktuationLetters[0] - resultSymbolsPunktuationLetters[2];

            return resultSymbolsPunktuationLetters;
        }

        static void SortWordsLongestShortest(string anyString)
        {
            int indexOfLongestWord = 0;
            string[] anyStringArray = anyString.Split(' ');

            for (int i = 0; i < anyStringArray.Length; i++)
            {
                string longestWord = anyStringArray[i];
                indexOfLongestWord = i;

                for (int j = i + 1; j < anyStringArray.Length; j++)
                {
                    if (longestWord.Length <= anyStringArray[j].Length)
                    {
                        longestWord = anyStringArray[j];
                        indexOfLongestWord = j;
                    }
                }
                anyStringArray[indexOfLongestWord] = anyStringArray[i];
                anyStringArray[i] = longestWord;
            }

            foreach (string elements in anyStringArray)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
