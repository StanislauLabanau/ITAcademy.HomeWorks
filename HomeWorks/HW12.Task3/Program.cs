using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HW12.Task3.Repositories;
using HW12.Task3.Types;
using log4net;
using log4net.Config;

namespace HW12.Task3
{
    class Program
    {
        static void ShowMotoCollection(IEnumerable<Motorcycle> motorcycles)
        {
            Logger.Log.Info("Motocycle collection was shown on the console");

            foreach (Motorcycle motorcycle in motorcycles)
            {
                Console.WriteLine($"{motorcycle.ID} {motorcycle.Model}, {motorcycle.Year}, {motorcycle.Odometr}");
            }
            Console.WriteLine();
        }

        static void ShowMoto(Motorcycle motorcycle)
        {
            Logger.Log.Info("Motorcycle instance was shown on the console");

            Console.WriteLine($"{motorcycle.ID} {motorcycle.Model}, {motorcycle.Year}, {motorcycle.Odometr} \n");
        }

        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("The program started");

            MotoRepository motoRepository = new MotoRepository();

            motoRepository.Create(new Motorcycle("BMW F650gs", 2000, 70000));
            motoRepository.Create(new Motorcycle("Suzuki DR650e", 2004, 50000));
            motoRepository.Create(new Motorcycle("Kawasaki KLR650", 2014, 35000));
            motoRepository.Create(new Motorcycle("Honda XRV750", 1998, 90000));

            ShowMotoCollection(motoRepository.GetAll());

            //Check GetByID
            Motorcycle testMotorcycle = new Motorcycle("KTM EXC450", 2003, 30000);
            Guid testID = testMotorcycle.ID;

            motoRepository.Create(testMotorcycle);

            ShowMotoCollection(motoRepository.GetAll());

            ShowMoto(motoRepository.GetByID(testID));

            //Check Update
            Motorcycle motorcycleUpdate = new Motorcycle(testID, "KTM EXC450", 2003, 40000);

            motoRepository.Update(motorcycleUpdate);

            ShowMotoCollection(motoRepository.GetAll());

            //Check Delete
            motoRepository.Delete(testID);

            ShowMotoCollection(motoRepository.GetAll());

            Console.ReadKey();
        }
    }
}
