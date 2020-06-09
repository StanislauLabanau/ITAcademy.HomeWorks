﻿using System;

namespace HW04.Task6
{
    class Program
    {
        static char EnterMovementSymbol()
        {
            char value = default(char);
            string valueConsole = default(string);

            do
            {
                if (string.IsNullOrEmpty(valueConsole))
                {
                    Console.WriteLine("enter the symbol W or S or A or D to move the character");
                }
                else
                {
                    Console.WriteLine("The format isn't correct, try again");
                }
                valueConsole = Console.ReadLine();
            }
            while (!Char.TryParse(valueConsole, out value) && (value != 'W' || value != 'S' || value != 'A' || value != 'D'));
            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the direction");

            switch (EnterMovementSymbol())
            {
                case 'W':
                    Console.WriteLine("Move forward");
                    break;
                case 'S':
                    Console.WriteLine("Move backward");
                    break;
                case 'A':
                    Console.WriteLine("Move left");
                    break;
                case 'D':
                    Console.WriteLine("Move right");
                    break;
                default:
                    Console.WriteLine("something is wrong");
                    break;
            }
        }
    }
}
