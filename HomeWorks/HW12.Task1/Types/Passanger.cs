using HW12.Task1.Enum;
using HW12.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Types
{
    class Passanger
    {
        public Passport Passport { get; set; }
        public Reservation Reservation { get; set; }
        public Ticket Ticket { get; set; }
        public BaggageType BaggageType { get; set; }
        public bool ForbiddenThings { get; set; }
        
        public Passanger(Passport passport, Reservation reservation, BaggageType baggageType)
        {
            Passport = passport;
            Reservation = reservation;
            BaggageType = baggageType;
        }

        public Passanger(Passport passport, Reservation reservation, BaggageType baggageType, bool forbiddenThings)
        {
            Passport = passport;
            Reservation = reservation;
            BaggageType = baggageType;
            ForbiddenThings = forbiddenThings;
        }

        public void GetTicket(Reservation reservation)
        {
            Ticket = new Ticket(reservation.FirstName, reservation.SecondName, reservation.PassportNumber, reservation.BaggageType, reservation.Destination, "Board number", "Ticket number");
        }

        public void CheckinOnline(Reservation reservation)
        {
            GetTicket(reservation);
        }
        public void GetRidOfForbiddenThings()
        {
            if (ForbiddenThings == true)
                ForbiddenThings = false;
        }
        public string Ansver()
        {
            return Console.ReadLine();
        }
    }
}
