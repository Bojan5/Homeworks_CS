using System;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 01.............................................................................

            //int sum = 0;

            //for (int i = 0; i < 10; i++)

            //{
            //    sum += (i + 1);
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();


            // TASK 02..............................................................................

            //int sumNumber = 0;

            //int[] num = new int[10];
            //Console.WriteLine("Enter any 10 numbers for displaying their sum and average :");

            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine()); 
            //    sumNumber += num[i];
            //}
            //Console.WriteLine("The sum of the numbers are :" + sumNumber);

            //int average;
            //average = sumNumber / 10;
            //Console.WriteLine("The average is :" + average);
            //Console.ReadLine();


            // TASK 03..............................................................................

            //int[] integerArr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int min;
            //int max;

            //min = integerArr[0];
            //max = integerArr[0];

            //for (int i = 0; i < integerArr.Length; i++)
            //{
            //    if (min > integerArr[i])
            //    {
            //        min = integerArr[i];
            //    }

            //    if (max < integerArr[i])
            //    {
            //        max = integerArr[i];
            //    }
            //}
            //Console.WriteLine("Minimum element :" + min);
            //Console.WriteLine("Minimum element index :" + Array.IndexOf(integerArr, min));

            //Console.WriteLine("Minimum element :" + max);
            //Console.WriteLine("Minimum element index :" + Array.IndexOf(integerArr, max));

            //Console.ReadLine();


            // TASK 04..................................................................................

            //int[] arrayWithDuplicates = { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            //int count = 0;

            //for (int i = 0; i < arrayWithDuplicates.Length; i++) { 

            //    for (int b = i + 1; b < arrayWithDuplicates.Length; b++)
            //    {
            //        if (arrayWithDuplicates[i] == arrayWithDuplicates[b])
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Total number of duplicate elements found in array :" + count);
            //Console.ReadLine();


            // TASK 05....................................................................................

            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] oddArray = new int[10];
            int[] evenArray = new int[10];

            int m;
            int n = 0;
            int k = 0;

            for (m = 0; m < oddEvenArray.Length; m++)
            {
                if (oddEvenArray[m] % 2 == 0)
                {
                    evenArray[n] = oddEvenArray[m];
                    n++;
                }
                else
                {
                    oddArray[k] = oddEvenArray[m];
                    k++;
                }
            }

            for (m = 0; m < n; m++)
            {
                Console.WriteLine("EvenArray elements are :" + evenArray[m]);
            }
            Console.WriteLine("-----------------------");

            for (m = 0; m < k; m++)
            {
                Console.WriteLine("OddArray elements are :" + oddArray[m]);
            }
            Console.ReadLine();


            // TASK 06.................................................................................

            //Console.WriteLine("Input a number to get a Day displayed");
            //int dayNum = Convert.ToInt32(Console.ReadLine());

            //switch(dayNum)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;

            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid day number.Please try again!");
            //        break;
            //}


            // TASK 07.....................................................................................

            //string[] userNames = { "user1", "user2", "user3" };
            //string[] passwords = { "first", "second", "third" };

            //while (true)
            //{
            //    Console.WriteLine("Please enter your username :");
            //    string userInput = (Console.ReadLine());

            //    Console.WriteLine("Please enter your password :");
            //    string passwordInput = (Console.ReadLine());

            //    if (userInput == userNames[0] && passwordInput == passwords[0])
            //    {
            //        Console.WriteLine("You are logged in successfully!");
            //        break;
            //    }

            //    else if (userInput == userNames[1] && passwordInput == passwords[1])
            //    {
            //        Console.WriteLine("You are logged in successfully!");
            //        break;
            //    }

            //    else if (userInput == userNames[2] && passwordInput == passwords[2])
            //    {
            //        Console.WriteLine("You are logged in successfully!");
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Incorrect username or password!");
            //    }
            //}
            //Console.ReadLine();
















        }
    }
}
