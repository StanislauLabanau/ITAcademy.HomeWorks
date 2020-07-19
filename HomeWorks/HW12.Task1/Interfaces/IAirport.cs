using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Interfaces
{
    interface IAirport
    {
        void AskYesOrNo() { }

        void Greeteengs()
        {
            Console.WriteLine("Good Day!");
        }

        void PassCheckinAirport() { }

        void PassSecurity() { }

        void PassPassportControl() { }
    }
}
