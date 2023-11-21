using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop
            MyCounter();
            PrintOddNumbers();

            //Do WHile Loop
            CutOff();
            NamesOfMyFriends();

            //While loop
            AnotherCounter();

            //break and continue
            Break();
            Continue();
            BreakAndContinue2();

            Console.Read();
        }
        // for loop 
        public static void MyCounter()
        {
            //increments by one
            Console.WriteLine("\nThis counter increments by 1");

            for (int count = 0; count < 20; count++)
            {
                Console.WriteLine(count);
            }

            //increments by 5
            Console.WriteLine("\nThis counter increments by 5");
            for (int count = 0; count < 55; count += 5)
            {
                Console.WriteLine(count);
            }

            // decrements by one
            Console.WriteLine("\nThis counter decrements by 1");

            for (int count = 40; count >= 0; count--)
            {
                Console.WriteLine(count);
            }

            //decrements by 5
            Console.WriteLine("\nThis counter decrements by 5");
            for (int count = 100; count >= 5; count -= 5)
            {
                Console.WriteLine(count);
            }
        }
        //For loop that prints odd numbers from 0-20
        public static void PrintOddNumbers()
        {
            Console.WriteLine("This loop prints odd numbers from 0-20");

            for (int oddNumbers = 1; oddNumbers <= 20; oddNumbers += 2)
            {
                Console.WriteLine(oddNumbers);
            }
        }

        //Do While loop
        public static void CutOff()
        {
            int cutOffMark = 200;

            do
            {
                Console.WriteLine("\n{0} is above the cutoff mark", cutOffMark);
                cutOffMark++;

            } while (cutOffMark < 205);

        }

        //Name of friends program
        public static void NamesOfMyFriends()
        {
            Console.WriteLine("\nWhat is your name?");
            String myName = Console.ReadLine();

            int numberOfFriends = 0;

            do
            {
                Console.WriteLine("Please enter the name of a friend");

                string nameMyFriend = Console.ReadLine();

                numberOfFriends++;

            } while (numberOfFriends < 5);
            Console.WriteLine("Good Job {0}! You've reached the max limit of {1}.", myName, numberOfFriends);
        }

        //While loop: Once condition is met, execute the number of times given
        public static void AnotherCounter()
        {
            int countStart = 1;

            while (countStart < 18)
            {
                Console.WriteLine(countStart);

                countStart++;
            }
        }

        //break & continue 
        static void Break()
        {
            for (int counter = 0; counter < 20; counter++)
            {
                Console.WriteLine(counter);

                if (counter == 10)
                {
                    Console.WriteLine("We break the count at 10"); 
                    break;
                }
            }
        }
        // continue
        static void Continue()
        {
            for (int counter = 0; counter < 20;)
            {
                if (counter % 2 == 1)
                {
                    counter++;
                    Console.WriteLine("Skip odd numbers"); 
                    continue;
                }
                Console.WriteLine(counter);
                counter++;
            }
        }

        static void BreakAndContinue2()
        {
            int counter = 0;

            while (counter <= 20)
            {
                if (counter == 10)
                {
                    Console.WriteLine("Break count at 10");
                    break;
                }
                if (counter % 2 == 0)
                {
                    counter++;
                    Console.WriteLine("Skip all even numbers");
                    continue;
                }
                Console.WriteLine(counter);
                counter++;
            }
        }
    }
}