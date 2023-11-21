using System;
using System.Collections.Generic;

namespace Constants_Methods_functions
{
    internal class Program
    {
        //const fields 
        const double PI = 3.14159265359;
        const int weeksInTheYear = 52, months = 12;
        const int hoursOfTheDay = 24;
        const string birthday = "Ist March, 1990";

        static void Main(string[] args)
        {
            Console.WriteLine("The value for PI is always: {0} \n ", PI);
            Console.WriteLine("The number of weeks in a year is always: {0} \n ", weeksInTheYear);
            Console.WriteLine("The number of hours in a day is always: {0} \n ", hoursOfTheDay);
            Console.WriteLine("My birthday is always: {0} \n ", PI);

            int num1 = 5;
            int num2 = 6;
            int sum = AddNumbers(num1, num2);

            Console.WriteLine("The addition of {0} and {1} is: {2} \n", num1, num2, sum);
            
            Introduction();
            SaySomething("Coding is Life!\n");

            int firstNumber = 30;
            int secondNumber = 3;
            int multipliedNumbers = MultiplyTwoNumbers(firstNumber, secondNumber);

            Console.WriteLine("The multiplication of {0} and {1} is: {2}; \n", firstNumber, secondNumber, multipliedNumbers);

            double firstOperand = 189746890;
            double secondOperand = 367;
            double divisionResult = DivideANumber(firstOperand, secondOperand);

            Console.WriteLine("The division of {0} by {1} is: {2}\n", firstOperand, secondOperand, divisionResult);

            int number = 10;
            int quadrupleResult = Quadruple(number);
            Console.WriteLine("The quadruple of {0} is: {1}\n", number, quadrupleResult);

            Console.WriteLine(MultiplyUserInput());
            Console.Read();
        }

        public static int AddNumbers(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        public static void Introduction()
        {
            Console.WriteLine("Hello!, my name is Precious \n");
        }

        public static void SaySomething(string message)
        {
            Console.WriteLine(message);
        }

        public static int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double DivideANumber(double firsOperand, double secondOperad)
        {
            return firsOperand / secondOperad;
        }

        public static int Quadruple(int number)
        {
            return number * 4;
        }
        
        public static int MultiplyUserInput()
        {
            Console.WriteLine("Enter a number");
            string? userInput = Console.ReadLine();
            int result = int.Parse(userInput);

            return result * result;
        }
    }
}