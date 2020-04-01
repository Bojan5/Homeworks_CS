using System;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 

            Console.WriteLine("Please select (1 for register or 2 for login)");
            string userInput;

            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput != "1" && userInput != "2")
                {
                    Console.WriteLine("Please enter correct answer ( 1 or 2 )");
                }
                // REGISTER

                if (userInput == "1")
                {
                    Console.WriteLine("Please enter your username");
                    string answer = Console.ReadLine();
                    bool isValid = true;

                    for (int i = 0; i < answer.Length; i++)
                    {
                        char ch = answer[i];

                        if ((!Char.IsPunctuation(ch)) || (!Char.IsSymbol(ch))) 
                        {
                            Console.WriteLine("@ and . must be present in the username");
                            isValid = false;
                            break;
                        }

                        if ((i == 0) && (i == answer.Length - 1) && (Char.IsDigit(ch)))
                        {
                            Console.WriteLine("The email cannot start and end with numbers or another special caracter");
                            isValid = false;
                            break;
                        }
                    }





                }
                // LOGIN

                if (userInput == "2")
                {
                    Console.WriteLine("Please enter your (username or email)");
                    break;
                }
            }
        }
    }
}

