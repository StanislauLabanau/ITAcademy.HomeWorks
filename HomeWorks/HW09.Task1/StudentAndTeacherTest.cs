using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ginny Weasley", 16);
            Student student = new Student("Harry Potter", 20, "Griffendoor");
            Teacher teacher = new Teacher("Severus Snape", 45, "defence against dark magic");

            person.ShowGreetingAndIntroduction();

            student.ShowGreetingAndIntroduction();
            student.GoToClass(10);
            
            teacher.ShowGreetingAndIntroduction();
            teacher.Explain();

            Console.Read();
        }
    }
}
