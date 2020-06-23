using System;

namespace AssamblyOne
{
    class EnduroMotorcycle : Motorcycle
    {
        //In this class only fields and methods with these access modifiers are accessible
        void SomeMetod()
        {
            _vinNumberProtected = "vin number enduro";
            StartEngineProtected();

            _vinNumberPrivateProtected = "vin number enduro";
            StartEnginePrivateProtected();

            _vinNumberPublic = "vin number enduro";
            StartEnginePublic();

            _vinNumberInternal = "vin number enduro";
            StartEngineInternal();
        }
    }

    class Program
    {
        //In this class only fields and methods with these access modifiers are accessible
        static void Main(string[] args)
        {
            Motorcycle firstMotorcycle = new Motorcycle();

            firstMotorcycle._vinNumberInternal = "vin number";
            firstMotorcycle.StartEngineInternal();

            firstMotorcycle._vinNumberProtectedInternal = "vin number";
            firstMotorcycle.StartEngineProtectedInternal();

            firstMotorcycle._vinNumberPublic = "vin mumber";
            firstMotorcycle.StartEnginePublic();

            Console.Read();
        }
    }
}
