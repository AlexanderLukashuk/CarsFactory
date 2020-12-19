using System;

namespace CarsFactory.Models
{
    public class Bus : Car
    {
        public override void Go()
        {
            Console.WriteLine("Bus is moving");
        }

        public override void BreakDown()
        {
            Console.WriteLine("Bus the broke down");
        }
    }
}