using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class Person
    {
        public string Name { set; private get; }
        public int Age { set; private get; }

        public Person(string name, int age)
        {
            if (age <= 15 || age >= 100)
            {
                Console.WriteLine("the wrong data for age area");
            }
            else { Age = age; }
            Name = name;
        }

        virtual public void ShowGreetingAndIntroduction()
        {
            Console.WriteLine($"Hello! my name is {Name}. I am {Age} years old.");
        }
    }
}
