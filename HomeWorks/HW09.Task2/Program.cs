using System;
using System.Collections.Generic;

namespace HW09.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Jerry", new SmallApartment()));
            persons.Add(new Person("Tom", new House()));
            persons.Add(new Person("Spike", new House(150, new Door("brown"))));

            foreach (Person person in persons)
            {
                person.ShowData();
            }

            Console.Read();
        }
    }
}
