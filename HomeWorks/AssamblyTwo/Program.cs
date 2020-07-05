using AssamblyOne;
using System;

namespace AssamblyTwo
{
    class SportMotorcycle : Motorcycle
    {
        //In this class only fields and methods with these access modifiers are accessible
        void SomeMetod()
        {
            _vinNumberProtected = "vin number sport";
            StartEngineProtected();

            _vinNumberPublic = "vin number sport";
            StartEnginePublic();

            _vinNumberProtectedInternal = "vin number sport";
            StartEngineProtectedInternal();
        }
    }

    class Program
    {
        //In this class only fields and methods with these access modifiers are accessible
        static void Main(string[] args)
        {
            Motorcycle firstMotorcycle = new Motorcycle();

            firstMotorcycle._vinNumberPublic = "vin mumber";
            firstMotorcycle.StartEnginePublic();

            Console.ReadKey();
        }
    }
}
