using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "unknown year";

        public string Make { get; set; } = "unknown make";

        public string Model { get; set; } = "unknown model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine($"This {GetType().Name} drives well.");
        }
    }
}
