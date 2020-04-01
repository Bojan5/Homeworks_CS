using System;

namespace Homework07
{

    //public class Dog
    //{
    //    public string Name;
    //    public string race;
    //    public string color;

    //    public void Eat()
    //    {
    //        Console.WriteLine("The dog is now eating");
    //    }

    //    public void Play()
    //    {
    //        Console.WriteLine("The dog is now playing");
    //    }

    //    public void ChaseTail()
    //    {
    //        Console.WriteLine("Dog is now chasing its tail.");
    //    }
    //}


    public class Human
    {
        public string firstName;
        public string lastaName;
        public string age;

        public void GetPersonStats()
        {
            Console.WriteLine($"Human's full name is {firstName} {lastaName} and is {age} years old!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TASK 01.........................................................................

            //string answer = Console.ReadLine();
            //char[] answerChar = answer.ToCharArray();
            //Array.Reverse(answerChar);

            //foreach (char letter in answerChar)
            //{
            //    Console.Write("{0} ", letter);
            //}
            //Console.ReadLine();


            // TASK 02...........................................................................

            //string word = Console.ReadLine();
            //string[] allWords = word.Split(' ');
            //Console.WriteLine(allWords.Length);


            // TASK 03............................................................................

            //string answer = Console.ReadLine().Replace(" ", "").ToLower();
            //char[] array = answer.ToCharArray();

            //string maxCharacter = "";
            //int count = 0;

            //foreach (var characters in array)
            //{
            //    int currentCount = 0;
            //    foreach (var currentCharacters in array)
            //    {
            //        if (characters == currentCharacters)
            //        {
            //            currentCount++;
            //        }
            //    }

            //    if (currentCount > count)
            //    {
            //        maxCharacter = characters.ToString();
            //        count = currentCount;
            //    }
            //}
            //Console.WriteLine("The highest frequency of character {0} appears number of times : {1}", maxCharacter, count);
            //Console.ReadLine();


            // TASK 04............................................................................................................................................

            //string textAfter = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";

            //string[] splitting = textAfter.Split(new char[] { ',' });

            //Console.WriteLine(splitting[1]);
            //Console.ReadLine();


            // TASK 05..............................................................................................................................................

            //int year = DateTime.Now.Year;
            //int month = DateTime.Now.Month;
            //int day = DateTime.Now.Day;
            //int hour = DateTime.Now.Hour;
            //int minute = DateTime.Now.Minute;
            //int second = DateTime.Now.Second;

            //Console.WriteLine($"Year: {year}, Month: {month}, Day: {day}, Hour: {hour}, Minute: {minute}, Second: {second}.");
            //Console.ReadLine();


            // TASK 06............................................................................................................

            //int i;

            //for(i = 2008; i <= 2020; i++)
            //{
            //    if(DateTime.IsLeapYear(i))
            //    {
            //        Console.WriteLine($"{i} is leap year!");
            //    }
            //}
            //Console.ReadLine();


            // TASK 07...............................................................................................................

            //Dog pitBull = new Dog();

            //Console.WriteLine("Input dog name:");
            //pitBull.Name = Console.ReadLine();

            //Console.WriteLine("Input dog rase:");
            //pitBull.race = Console.ReadLine();

            //Console.WriteLine("Input dog color");
            //pitBull.color = Console.ReadLine();

            //Console.WriteLine("Chose the action of your dog:");
            //Console.WriteLine("1 - Eat");
            //Console.WriteLine("2 - Play");
            //Console.WriteLine("3 - ChaseTail");
            //string option = Convert.ToString(Console.ReadLine());

            //switch (option)
            //{
            //    case "1":
            //        pitBull.Eat();
            //        break;
            //    case "2":
            //        pitBull.Play();
            //        break;
            //    case "3":
            //        pitBull.ChaseTail();
            //        break;
            //    default:
            //        Console.WriteLine("You did not choose any action!");
            //        break;
            //}
            //Console.ReadLine();


            // TASK 08...................................................................................................................

            Human people = new Human();
            Console.WriteLine("Please input the requured information!");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Input first name:");
            people.firstName = Console.ReadLine();


            Console.WriteLine("Input last name:");
            people.lastaName = Console.ReadLine();


            Console.WriteLine("Input age:");
            people.age = Console.ReadLine();

            Console.WriteLine("---------------------------------------");
            people.GetPersonStats();

            Console.ReadLine();
        }
    }
}
