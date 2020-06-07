using System;

namespace HW03.Task3
{
    class Person
    {
        public string name { get; set; }
        public int yearOfBirthday { get; set; }
        public byte monthOfBirthday { get; set; }
        public int age { get; set; }
        public Person(string name, int yearOfBirthday, byte monthOfBirthday)
        {
            this.name = name;
            this.yearOfBirthday = yearOfBirthday;
            this.monthOfBirthday = monthOfBirthday;
        }
        public void GetAge(int currentYear, byte currentMonth)
        {
           if (currentMonth == monthOfBirthday)
            {
                age = (currentYear - yearOfBirthday);
            }
           else
            {
                age = (currentYear - yearOfBirthday)-1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string currentYearConsole = "";
            string currentMonthConsole = "";
            string name = "";
            string yearOfBirthConsole = "";
            string monthOfBirthConsole = "";

            int currentYear;
            byte currentMonth;
            int yearOfBirth;
            byte monthOfBirth;

            //current year 
            do
            {
                if (string.IsNullOrEmpty(currentYearConsole))
                {
                    Console.WriteLine("Please, enter the current year");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                currentYearConsole = Console.ReadLine();
            }
            while (!Int32.TryParse(currentYearConsole, out currentYear));

            //current month
            do
            {
                if (string.IsNullOrEmpty(currentMonthConsole))
                {
                    Console.WriteLine("Please, enter the current month");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                currentMonthConsole = Console.ReadLine();
            }
            while (!Byte.TryParse(currentMonthConsole, out currentMonth) || currentMonth>12 || currentMonth<=0);

            // name
            Console.WriteLine("Please, enter the name of the person");
            name = Console.ReadLine();

            // year of birth
            do
            {
                if (string.IsNullOrEmpty(yearOfBirthConsole))
                {
                    Console.WriteLine("Please, enter the year of birth");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                yearOfBirthConsole = Console.ReadLine();
            }
            while (!Int32.TryParse(yearOfBirthConsole, out yearOfBirth) || yearOfBirth>=currentYear);

            //month of birth
            do
            {
                if (string.IsNullOrEmpty(monthOfBirthConsole))
                {
                    Console.WriteLine("Please, enter the month of birth");
                }
                else
                {
                    Console.WriteLine("The value is not correct, try to enter another value");
                }
                monthOfBirthConsole = Console.ReadLine();
            }
            while (!Byte.TryParse(monthOfBirthConsole, out monthOfBirth) || monthOfBirth > 12 || monthOfBirth<=0);

            Person person = new Person(name, yearOfBirth, monthOfBirth);
            person.GetAge(currentYear, currentMonth);
            Console.WriteLine($"{person.name} is {person.age} years old");
        }
    }
}
