using CarsFactory.Interfaces;

namespace CarsFactory.Models
{
    public class CarFactory : ICarFactory
    {
        public ICar Create(CarType car)
        {
            switch (car)
            {
                case CarType.Car:
                {
                    return new Car();
                }
                case CarType.Bus:
                {
                    return new Bus();
                }
                case CarType.Truck:
                {
                    return new Truck();
                }
                case CarType.Tractor:
                {
                    return new Tractor();
                }
                default:
                {
                    return new Car();
                }
            }
        }
    }
}