using CarsFactory.Models;

namespace CarsFactory.Interfaces
{
    public interface ICarFactory
    {
        ICar Create(CarType car);
    }
}