using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class Teacher:Person
    {
        public string Subject { get; private set; }
        public Teacher (string name, int age, string subject):base (name, age)
        {
            Subject = subject;
        }

        public override void ShowGreetingAndIntroduction()
        {
            base.ShowGreetingAndIntroduction();
            Console.WriteLine($"I'm {Subject} teacher");
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
