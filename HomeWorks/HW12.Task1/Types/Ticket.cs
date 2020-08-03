using HW12.Task1.Enum;
using HW12.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Types
{
    class Ticket : Reservation
    {
        public string BoardNumber { get; private set; }
        public string TicketNumber { get; private set; }

        public Ticket(string firstName, string secondName, string passportNumber, BaggageType baggageType, Destination destination, string boardNumber, string ticketNumber) : base(firstName, secondName, passportNumber, baggageType, destination)
        {
            BoardNumber = boardNumber;
            TicketNumber = ticketNumber;
        }
    }
}

