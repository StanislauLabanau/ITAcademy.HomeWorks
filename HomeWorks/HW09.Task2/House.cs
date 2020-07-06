using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task2
{
    class House
    {
        private int _area;
        public Door Door { get; private set; }

        public int Area
        {
            get
            {
                return _area;
            }

            set
            {
                if (value <= 0) { Console.WriteLine("The wrong area value"); }
                else { _area = value; }
            }
        }

        public House()
        {
            Area = 100;
            Door = new Door("wite");
        }

        public House(int area)
        {
            Area = area;
        }

        public House (int area, Door door)
        {
            Area = area;
            Door = door;
        }

        public void ShowData()
        {
            Console.WriteLine($"The house area is {Area}");
            Door.ShowData();
        }

        public Door GetDoor(string color)
        {
            return new Door(color);
        }
    }
}
