namespace TryCatchAndFinally
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //solution1
            Console.WriteLine(AddTwoNumbers());

            //solution2
            Console.WriteLine(DivideTwoNumbers());

            Console.Read();
        }
        public static int AddTwoNumbers()
        {
            int result = 0;

            Console.WriteLine("Please enter a number:");
            string numberInput1 = Console.ReadLine();

            Console.WriteLine("Please enter another number:");
            string numberInput2 = Console.ReadLine();
            try
            {
                int input1 = int.Parse(numberInput1);
                int input2 = int.Parse(numberInput2);

                result = input1 + input2;     
                Console.WriteLine("The addition of {0} and {1} is: {2} ", input1, input2, result);               
            }                                     

            catch (FormatException) 
            {                
                Console.WriteLine("Invalid input! Please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your input is too large or too small. Enter just a number");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value was emply (null)");
            }
            finally 
            {
                Console.WriteLine("The is called anyways");
            }
            return 0;
        }
        
        public static int DivideTwoNumbers()
        {
           int firstNumber = 10;
            int secondNumber = 0;
            int result = 0;

            try
            {
                result = firstNumber / secondNumber;
                Console.WriteLine("The division of {0} and {1} is: ", firstNumber, secondNumber );
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Number can't be divisible by zero");
            }
            return result;
        }
    }
}