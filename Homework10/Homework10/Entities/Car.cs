using System;
using Homework10.Enum;

namespace Homework10.Entities
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Doors;
        public int TopSpeed;
        public int ID;

        public Consumption Consumption;
        public EngineType Engine;

        public void PrintInfo()
        {
            Console.WriteLine("The car is {Brand}, model {Model} and has {Doors} doors, and max speed is {TopSpeed} km with ID {ID}");
        }
    }
}
