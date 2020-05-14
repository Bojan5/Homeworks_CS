using System;


namespace Homework10.Helpers
{
   public class CarID
    {
        public static int GenerateCarID()
        {
            Random rand = new Random();
            return rand.Next(1, 9999999);
        }
    }
}
