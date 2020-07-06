using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task2
{
    class Door
    {
        public string Color { get; private set; }

        public Door (string color)
        {
            Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"The door color is {Color}");
        }
    }
}
