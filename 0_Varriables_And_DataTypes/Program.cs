using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Variables_And_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World! \n");
            Console.WriteLine("Type anything and hit Enter!");
            Console.ReadLine();

            Console.Beep();
            Console.WriteLine("1 beeped!\n");

            Console.Beep();
            Console.WriteLine("1 beeped again!");

            //declaring a variable:
            int num1;
            //declaring multiple variables
            int num2, num3, num4, num5, num6;


            num1 = 3; //initializing the variable

            Console.WriteLine(num1);

            //Add two variables:
            int num_2 = 20; //declaring and initializing the variable
            int sum = num1 + num_2;

            Console.WriteLine(sum);

            //using concatenation:
            Console.WriteLine("Num1 is: " + num1);
            Console.WriteLine("Num2 is: " + num_2);
            Console.WriteLine("Num1 + Num2 is: " + sum);

            num2 = 300; //overriding a variable
            int sumTotal = num1 + num2;
            Console.WriteLine("Num1: " + num1 + " + Num2: " + num2 + " is : " + sumTotal);

            //using other data types

            //double data type
            double dbl1, dbl2, dblDiv; //declaring multiple variables

            dbl1 = 80.4567;
            dbl2 = 2.9035;
            dblDiv = dbl1 / dbl2;

            Console.WriteLine("db1/db2 is: " + dblDiv);

            //float data type
            float flt1, flt2, fltDiv;

            flt1 = 80.4567f;
            flt2 = 2.9035f;
            fltDiv = flt1 / flt2;

            Console.WriteLine("db1/db2 is: " + fltDiv);

            //working with multiple data types
            long mylong = 1234567890111213147;
            int myint = 1234567890;

            long result = mylong + myint; //would throw no error due to lower to higher implicit conversion

            Console.WriteLine(result);

            // int result2 = mylong + myint; // throws an error - requires a cast
            //int result3 = myint / mylong; // exception - explicit conversion required

            //String data type

            string myName = "Precious";
            string message1 = "My name is ";

            Console.WriteLine(message1 + myName); //prints a string onto the console

            //Strings and Methods
            // 1) Length
            string message = "Put in the effort";
            int getLengthOfMessage = message.Length;

            Console.WriteLine("The number of characters in the string 'message' is " + getLengthOfMessage);

            // 2) IndexOf

            int getTheIndex = message.IndexOf("effort");
            Console.WriteLine("The index of the substring 'effort' is " + getTheIndex);

            // 3) Substring
            string substringFromAnIndex = message.Substring(7);
            Console.WriteLine("The Substring from the index of 7 is: " + substringFromAnIndex);

            // 4) Replace
            string replaceAString = message.Replace("effort", "work");
            Console.WriteLine(replaceAString + " : In this new string, 'effort' was replaced with 'work' in all occurrences");

            string replaceAChar = message.Replace("e", "a");
            Console.WriteLine(replaceAChar + " : In this new string, 'e' was replaced with 'a' in all occurrences");

            // 5) ToUpper & ToLower
            string allInUppercase = message.ToUpper();
            Console.WriteLine(allInUppercase);

            string allInULowercase = message.ToLower();
            Console.WriteLine(allInULowercase);

            // 6) Trim
            string message2 = "      Put in the effort!  ";
            string removeWhiteSpaces = message2.Trim();

            Console.WriteLine(removeWhiteSpaces);

            // 7) Split
            string fruits = "Banana,Mango,Orange,Apple,Pineapple";
            string[] splitString = fruits.Split(','); //splits a string into an array of substring

            foreach (string fruit in splitString)
            {

                Console.WriteLine('"' + fruit + '"'); //Items come out with double quote
            }

            // Console Methods

            Console.WriteLine("hello world"); //Prints the text and jumps to a new line

            Console.Write("Hello!"); //Prints the text without jumping - remains on same line
            //Console.Write("Continued writing on same line"); // continues to write on same line

            //Printing an input to the console
            Console.WriteLine("Enter a string and press enter");
            string readInput = Console.ReadLine();
            Console.WriteLine(readInput);

            //Getting the ASCII value of an input
            Console.WriteLine("Enter a character and press enter");

            int printAsciiValue = Console.Read();
            Console.WriteLine("The ASCII value of your input is: " + printAsciiValue);
            //Console.ReadKey();

            //Console.ReadKey(); // returns the ASCII value of an input

            //Console.BackgroundColor = ConsoleColor.Black;
            // Console.ForegroundColor = ConsoleColor.DarkGreen;


            //Type Conversion - implicit and explicit conversion
            int firstNumber = 5456;
            double mySecondNumber = firstNumber;

            Console.WriteLine(mySecondNumber);

            //explicit conversion
            int count = 1234;
            byte convertCount = (byte)count;//data loss will occur

            Console.WriteLine(convertCount);

            //type conversion by methods
            double myDouble = 3.57;
            string myString = myDouble.ToString();

            Console.WriteLine(myString);

            float myFloat = 34.6f;
            string stringFloat = myFloat.ToString();

            Console.WriteLine(stringFloat);

            //Parsing 
            //from string to an integer
            string firstString = "1234";
            string secondString = "5678";

            int myNum1 = Int32.Parse(firstString);
            int myNum2 = Int32.Parse(secondString);
            int sumResult = myNum1 + myNum2;

            Console.WriteLine(sumResult);

            //String Manipulation

            // 1) string concatenation
            int myAge = 30;
            Console.WriteLine("My name is " + myName + " I am " + myAge + " years old");

            // 2) String Formatting 

            Console.WriteLine("My name is {0}, I am {1} years old.", myName, myAge);

            //3) String Interpolation 
            Console.WriteLine($"My name is {myName}, I am {myAge} years old.");

            //4) Verbatim String 

            Console.WriteLine(@"In C#, a verbatim string is a string literal that allows you to define a string 
                                without escaping characters like backslashes or escape sequences. 
                                Verbatim strings are useful when you want to include characters like 
                                backslashes, newlines, or tabs exactly as they are, 
                                without having to escape them with additional backslashes.

                                Verbatim strings are particularly useful when dealing with 
                                file paths, regular expressions, XML, JSON, 
                                or any scenario where you need to work with strings 
                                containing a lot of backslashes or special characters 
                                without the need to escape them manually.");

            //writing file path //verbatim string has a special use case like file path.
            Console.WriteLine(@"C:\Users\Admin\Photos\Dog.png");

            Console.WriteLine(@"Doing all it takes...\n This can lead to success!");

            /* String Methods*/

            //substring - returns a substring from a specified index
            string expression = "I am going home to finish the work.";
            string sub = expression.Substring(5);

            Console.WriteLine(sub);

            //ToLower - returns the string in lowercase
            string toLowerCase = myName.ToLower();

            Console.WriteLine(toLowerCase);

            //ToUpper - returns the string in upper case
            string toUpperCase = myName.ToUpper();

            Console.WriteLine(toUpperCase);

            //Trim 
            string message3 = "         Good work speaks for itself";
            string trimWhiteSpaces = message3.Trim();

            Console.WriteLine(trimWhiteSpaces);

            //IndexOf - takes in a character or a string and returns its index
            string fullName = "Precious Oranye";
            int getIndex = fullName.IndexOf("Oranye");
            int getIndex1 = fullName.IndexOf("o");

            Console.WriteLine(getIndex);
            Console.WriteLine(getIndex1);

            //IsNullOrWhiteSpace - returns True if a string is null, empty or contains white spaces
            //otherwise returns false.
            string string1 = null;
            string string2 = "";
            string string3 = "Apple";
            string string4 = " ";

            bool checkString1 = string.IsNullOrWhiteSpace(string1);
            bool checkString2 = string.IsNullOrWhiteSpace(string2);
            bool checkString3 = string.IsNullOrWhiteSpace(string3);
            bool checkString4 = string.IsNullOrWhiteSpace(string4);

            Console.WriteLine("It\'s null or white space: {0}", checkString1);
            Console.WriteLine("It\'s null or white space: {0}", checkString2);
            Console.WriteLine("It\'s null or white space: {0}", checkString3);
            Console.WriteLine("It\'s null or white space: {0}", checkString4);

            //Concat - concatenates strings
            string firstName = "Precious";
            string lastName = "Oranye";
            string concatenateStrings = string.Concat(firstName, " ", lastName);
            Console.WriteLine("My name is: {0}", concatenateStrings);

            //string.Format
            string myFirstName = "Precious";
            string myLastName = "Oranye";
            string age = "32";

            string formatString = string.Format("My name is {0} {1}, I am {2} years old.", myFirstName, myLastName, age);

            Console.WriteLine(formatString);

            //Using special characters with escape
            string myMessage = "\"Today's work would take more time\" says the manager.";
            Console.WriteLine(myMessage);

            string myMessage2 = "This is a string with a \\ and a \\n without a line break";
            Console.WriteLine(myMessage2);

            //Using the 'var' Keyword - used to declare implicitly local variables

            //var total = 100;
            //var myNum; //this will throw an error because it is implicitly typed and must be initialized.

            //var text = "Warm code"; //string
            //var myAge = 32; //integer
            //var isFalse = false; //boolean

            //again, var variables cannot be null
            //var mynum = null; //cannot assign null to an implicitly typed variable.   
        }
    }
}

