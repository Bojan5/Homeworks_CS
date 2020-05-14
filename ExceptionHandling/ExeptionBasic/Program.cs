using System;

namespace ExeptionBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter a number for division: ");

            int result = 0;

            try
            {
                int number = int.Parse(Console.ReadLine());
                result = 10 / number;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something wrong happend...: ");
            }
            finally
            {
                Console.WriteLine("I'm heare finaly: ");
            }


           

            //Console.WriteLine("The division of 10 with number is: " + result);

            Console.WriteLine("The application continues...: ");



            Console.ReadLine();
        }
    }
}
