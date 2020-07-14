using HW12.Task1.Types;
using HW12.Task1.Enum;
using System;

namespace HW12.Task1
{
    class Program
    {
        delegate void GoOnBoard(Passanger passanger);
        static void Main(string[] args)
        {
            MinskAirport minskAirport = new MinskAirport();
            Passport passport = new Passport("Stanislau", "Labanau", "BM1234567", Constants.Visa);
            Reservation reservation = new Reservation("Stanislau", "Labanau", "BM1234567", BaggageType.Carryon, Destination.Brussel);
            Passanger passanger = new Passanger(passport, reservation, BaggageType.Carryon, Constants.ForbiddenThings);

            minskAirport.Greeteengs();

            GoOnBoard goOnBoard;

            if (passanger.Ticket is null)
            {
                goOnBoard = minskAirport.PassCheckin;
                goOnBoard += minskAirport.PassSecurity;
                goOnBoard += minskAirport.PassPassportControl;
            }
            else
            {
                goOnBoard = minskAirport.PassSecurity;
                goOnBoard += minskAirport.PassPassportControl;
            }

            try
            {
                goOnBoard(passanger);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
