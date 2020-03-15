using System;

namespace homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 01.................................................................

            Console.WriteLine("Input number:");
            int number;

            bool parseNum = int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            Console.WriteLine("Input another number:");
            int inputNumber;

            bool parsedNum = int.TryParse(Console.ReadLine(), out inputNumber);

            int b = 1;

            while (b <= inputNumber)
            {
                Console.WriteLine(inputNumber--);
            }
            Console.ReadLine();


            // TASK 02....................................................................

            Console.WriteLine("Input number:");

            bool parseEven = int.TryParse(Console.ReadLine(), out int evenNumber);

            for (int i = 2; i <= evenNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();



            Console.WriteLine("Input number:");

            bool parseOdd = int.TryParse(Console.ReadLine(), out int evenOdd);

            for (int i = 1; i <= evenOdd; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();



            // TASK 03 .................................................................


            string[] names = new string[] { };

            while (true)
            {
                Console.WriteLine("Enter a name");

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = Console.ReadLine();

                Console.WriteLine("Do you want to add another name?");
                string answer;

                while (true)
                {
                    answer = Console.ReadLine().ToLower();

                    if (answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Please enter correct answer (Y or N)");
                    }
                    else
                    {
                        break;
                    }
                }

                if (answer == "n")
                {
                    break;
                }
            }

            for (var i = 0; i < names.Length; i++)
            {
                var name = names[i];

                if (i != names.Length - 1)
                {
                    name += ", ";
                }

                Console.Write(name);
            }
            Console.ReadLine();
        }
    }
}
