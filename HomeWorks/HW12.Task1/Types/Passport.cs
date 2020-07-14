using HW12.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Types
{
    class Passport : IPersonalData
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PassportNumber { get; set; }
        public bool Visa { get; private set; }

        public Passport(string firstName, string secondName, string passportNumber)
        {
            FirstName = firstName;
            SecondName = secondName;
            PassportNumber = passportNumber;
        }
        public Passport(string firstName, string secondName, string passportNumber, bool visa)
        {
            FirstName = firstName;
            SecondName = secondName;
            PassportNumber = passportNumber;
            Visa = visa;
        }
    }
}
