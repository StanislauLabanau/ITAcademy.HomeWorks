using System;
using System.Text;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "1a!2.3!!.. 4.!.?6 7! ..?";

            int index = myString.IndexOf('?');

            StringBuilder myStringPart1 = new StringBuilder(myString.Substring(0, index));

            for (int i = 0; i<myStringPart1.Length; i++)
            {
                if (myStringPart1[i] == '.')
                {
                    myStringPart1.Remove(i, 1);
                    i--;
                }
            }
                                   
            StringBuilder myStringPart2 = new StringBuilder(myString.Substring(index, myString.Length-index));
            myStringPart2.Replace(' ', '_');

            StringBuilder myStringSB = new StringBuilder();
            myStringSB = myStringPart1.Append(myStringPart2);

            Console.WriteLine("the initial string \n" + myString +"\nafter conversion\n" + myStringSB);

            Console.ReadLine(); 
        }
    }
}
