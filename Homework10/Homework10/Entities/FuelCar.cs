using Homework10.Enum;
using System;
namespace Homework10.Entities
{
   public class FuelCar : Car
    {
        public int FuelCapacity;
        public int CurrentFuel;

        public void Drive(int distance)
        {
            if(distance > FuelCapacity)
            {
                Console.WriteLine("Not enought fuel");
            }
            else
            {
                Console.WriteLine("The Car is sucsessfuly drived");
            }
        }

        public void Refuel(int fuel)
        {
            if(fuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity} litres");
            }
            else
            {
                Console.WriteLine($"Tank has been fueled with {fuel} l.");
            }
        }
    }
}
