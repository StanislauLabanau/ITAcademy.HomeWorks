using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task3.Types
{
    class Motorcycle
    {
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Guid ID { get; private set; }
        public int Odometr { get; private set; }

        internal Motorcycle()
        {
            Model = default;
            Year = default;
            ID = Guid.NewGuid();
            Odometr = default;
        }

        internal Motorcycle(string model, int year, int odometr)
        {
            Model = model;
            Year = year;
            ID = Guid.NewGuid();
            Odometr = odometr;
        }

        internal Motorcycle(Guid id, string model, int year, int odometr)
        {
            Model = model;
            Year = year;
            ID = id;
            Odometr = odometr;
        }
    }
}
