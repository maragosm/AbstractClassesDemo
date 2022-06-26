using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() { }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {GetType().Name} can drive, and it drives really well!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This particular {GetType().Name} is a {GetType().BaseType.Name} and it drives smooth and well.");
        }
    }
}
