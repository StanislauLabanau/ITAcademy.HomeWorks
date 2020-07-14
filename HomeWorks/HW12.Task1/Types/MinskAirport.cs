using HW12.Task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Types
{
    class MinskAirport : IAirport
    {
        private void AskYesOrNo()
        {
            Console.WriteLine($"Pleace write {Constants.PositiveAnsver} if yes or {Constants.NegativeAnsver} if no");
        }
        public void Greeteengs()
        {
            Console.WriteLine(Constants.GreeteengFirstMinsk);
            Console.WriteLine(Console.ReadLine() + Constants.GreeteengSecondtMinsk);
        }

        public void PassCheckin(Passanger passanger)
        {
            while (passanger.Ticket is null)
            {
                if (passanger.Passport.FirstName == passanger.Reservation.FirstName && passanger.Passport.SecondName == passanger.Reservation.SecondName && passanger.Passport.PassportNumber == passanger.Reservation.PassportNumber && passanger.BaggageType == passanger.Reservation.BaggageType)
                {
                    passanger.GetTicket(passanger.Reservation);
                    Console.WriteLine(Constants.CheckinSuccess);
                }

                else
                {
                    throw new Exception(Constants.CheckinUnsuccess);
                }
            }
            Console.WriteLine(Constants.CheckinOnline);
        }

        public void PassSecurity(Passanger passanger)
        {
            while (passanger.ForbiddenThings)
            {
                Console.WriteLine(Constants.SecurityUnsuccessFirst);
                AskYesOrNo();
                if (passanger.Ansver().Equals(Constants.PositiveAnsver))
                    passanger.GetRidOfForbiddenThings();
                else
                    throw new Exception(Constants.SecurityUnsuccessSecond);

            }
            Console.WriteLine(Constants.SecuritySuccess);
        }

        public void PassPassportControl(Passanger passanger)
        {
            if (passanger.Passport.Visa == true && passanger.Ticket.BoardNumber == "Board number")
            {
                Console.WriteLine(Constants.PassportControlSuccess);
            }
            else
            {
                throw new Exception(Constants.PassportControlUnsuccess);
            }
        }
    }
}
