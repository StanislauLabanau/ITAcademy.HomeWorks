using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1.Interfaces
{
    interface IPersonalData
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        string PassportNumber { get; set; }
    }
}
