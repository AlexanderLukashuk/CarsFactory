using System;

namespace CarsFactory.Models
{
    public class Truck : Car
    {
        public override void Go()
        {
            Console.WriteLine("Truck is moving");
        }

        public override void BreakDown()
        {
            Console.WriteLine("Truck the broke down");
        }
    }
}