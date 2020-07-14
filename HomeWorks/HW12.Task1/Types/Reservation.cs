using HW12.Task1.Enum;
using HW12.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Types
{
    class Reservation : IPersonalData
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PassportNumber { get; set; }
        public BaggageType BaggageType { get; set; }
        public Destination Destination { get; set; }

        public Reservation (string firstName, string secondName, string passportNumber, BaggageType baggageType, Destination destination)
        {
            FirstName = firstName;
            SecondName = secondName;
            PassportNumber = passportNumber;
            BaggageType = baggageType;
            Destination = destination;
        }
    }
}
