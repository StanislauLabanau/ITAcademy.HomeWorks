using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task2
{
    class Person
    {
        public string Name { get; private set; }
        public House House { get; private set; }

        public SmallApartment SmallApartment { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, House house)
        {
            Name = name;
            House = house;
        }

        public void ShowData()
        {
            Console.WriteLine(Name);
            House.ShowData();
        }
    }
}
