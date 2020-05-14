using Homework10.Entities;
using System;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricCar MyCar = new ElectricCar
            {
                Brand = "BMW",
                Doors = 4,
                Engine = Enum.EngineType.Electric,
            };
            MyCar.Drive(122);
        }
    }
}
