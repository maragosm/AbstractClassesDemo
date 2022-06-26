using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            var vehicles = new List<Vehicle>();

            
            var car1 = new Car() { Year = "2002", Make = "Chevy", Model = "Impala", HasTrunk = true };
            var motorcycle1 = new Motorcycle() { Year = "2002", Make = "Honda", Model = "Intercepter", HasSideCart = true };
            Vehicle car2 = new Car() { Year = "2001", Make = "Dodge", Model = "Avenger" };
            Vehicle motorcycle2 = new Motorcycle() { Year = "2002", Make = "Suzuki", Model = "GSX-R1" };

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This vehicles properties are {vehicle.Year}, {vehicle.Make}, {vehicle.Model}.");
            }

            car1.DriveAbstract();
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
