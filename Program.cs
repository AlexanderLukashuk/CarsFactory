using System;
using CarsFactory.Models;
using CarsFactory.Interfaces;

namespace CarsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory carFactory = new CarFactory();
            ICar car = carFactory.Create(CarType.Bus);
            car.Go();

            Console.ReadLine();
        }
    }
}
