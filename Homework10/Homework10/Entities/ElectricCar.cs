using Homework10.Enum;
using System;
namespace Homework10.Entities
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity = 100;
        public double BatteryUsage;

        public void Drive(int distance)
        {

            if(distance > BatteryCapacity )
            {
                Console.WriteLine("Not enought battery");
            }
            else
            {
                Console.WriteLine("The Car is sucsessfuly drived");
            }
        }

        public void Recharge(int minutes)
        {
            var recharge = minutes / 10;

            if(minutes == 100 * 10)
            {
                Console.WriteLine($"Can't charge longer that {minutes} minutes");
            }
            else
            {
                BatteryCapacity += recharge;

                Console.WriteLine($"The Battery has been charged for {recharge}%");
            }
        }
    }
}
