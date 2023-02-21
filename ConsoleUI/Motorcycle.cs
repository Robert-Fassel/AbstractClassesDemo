using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving");
        }
        public bool HasSideCar { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's Virtual Drive Method");
        }
    }
}
