using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class Student:Person
    {
        public string Faculty { get; private set; }

        public Student (string name, int age, string faculty):base (name, age)
        {
            Faculty = faculty;
        }

        public override void ShowGreetingAndIntroduction()
        {
            base.ShowGreetingAndIntroduction();
            Console.WriteLine($"My faculty is {Faculty}");
        }

        public void GoToClass(int classNumber)
        {
            Console.WriteLine($"I'm going to class {classNumber}");
        }
    }
}
