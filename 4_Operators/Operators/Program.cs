namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solution1 Unary Operator
            UnaryOperators();
            
            //increment operator
            Increment_DecrementOperators();

            //Additive operator
            AdditiveOperator(10, 40);

            //Subtractive operator
            SubtractiveOperator(40, 20);

            //multiplicative Operator
            MultiplicativeOperator(10, 10);

            //Divisive Operator
            DivisiveOperator(100, 30);

            //Modulus Operator
            ModulusOperator(100, 30);

            //Relational/Comparison Operators
            RelationalOperators(50, 10);

            //Logical operators
            LogicalOperators();
            
            Console.Read();
        }
        public static void UnaryOperators()
        {
            int num1 = 5;
            int num2 = -10;
            bool submitted = false;
            
            int num3 = -num1;
            int num4 = -num2;
            bool submitStatus = !submitted;

            Console.WriteLine("{0} multiplied by minus is: {1}", num1, num3);
            Console.WriteLine("{0} multiplied by minus is: {1}", num2, num4);
            Console.WriteLine("The opposite of {0} is: {1}", submitted, submitStatus);
        }

        public static void Increment_DecrementOperators()
        {
            int firstNumberIncrement = 0;
            int firstNumberDecrement = 10;

            //For first increment
            //pre-increment
            Console.WriteLine(++firstNumberIncrement); //modifies a value after it was called
            Console.WriteLine(++firstNumberIncrement); //Hence changes are visible immediately the value is called
            Console.WriteLine(++firstNumberIncrement); 
            Console.WriteLine(++firstNumberIncrement);
            Console.WriteLine(++firstNumberIncrement);

            //post-increment operators
            Console.WriteLine(firstNumberIncrement++);
            Console.WriteLine(firstNumberIncrement);

            //For Second increment
            //pre-decrement
            Console.WriteLine(--firstNumberDecrement);
            Console.WriteLine(--firstNumberDecrement);
            Console.WriteLine(--firstNumberDecrement);
            Console.WriteLine(--firstNumberDecrement);
            Console.WriteLine(--firstNumberDecrement);

            //post-decrement
            Console.WriteLine(firstNumberDecrement--); //modifies a value after it was called 
            Console.WriteLine(firstNumberDecrement);//hence, changes reflects on the next call of same value
        }

        public static void AdditiveOperator(int firstInteger, int secondInteger)
        {
            int result = firstInteger +  secondInteger;
            Console.WriteLine("The result of {0} plus {1} is: {2}", firstInteger, secondInteger, result);
        }

        public static void SubtractiveOperator(int firstInt, int secondInt)
        {
            int result = firstInt - secondInt;
            Console.WriteLine("The result of {0} minus {1} is: {2}", firstInt, secondInt, result);
        }

        public static void MultiplicativeOperator(int firstInt, int secondInt)
        {
            int result = firstInt * secondInt;
            Console.WriteLine("The result of {0} multiplied by {1} is: {2}", firstInt, secondInt, result);
        }

        public static void DivisiveOperator(double firstInt, double secondInt)
        {
            double result = firstInt / secondInt;
            Console.WriteLine("The result of {0} divided by {1} is: {2}", firstInt, secondInt, result);
        }

        public static void ModulusOperator(int firstParameter, int secondParameter)
        {
            int result = firstParameter % secondParameter;
            Console.WriteLine("The result of {0} modulus {1} is: {2}", firstParameter, secondParameter, result);
        }

        public static void RelationalOperators(int firstNumber, int secondNumber)
        {
            //Greater than (>)
            bool greaterThan = firstNumber > secondNumber;
            Console.WriteLine("{0} is greater than {1}: {2}", firstNumber, secondNumber, greaterThan);

            //Less than (<)
            bool lessThan = firstNumber < secondNumber;
            Console.WriteLine("{0} is less than {1}: {2}", firstNumber, secondNumber, lessThan);

            //is equal to (==)
            bool isEqualTo = firstNumber == secondNumber;
            Console.WriteLine("{0} is equal to {1}: {2}", firstNumber, secondNumber, isEqualTo);

            //Not equal to (!=)
            bool isNotEqualTo = firstNumber != secondNumber;
            Console.WriteLine("{0} is not equal to {1}: {2}", firstNumber, secondNumber, isNotEqualTo);

            //Greater than or equal to (>=)
            bool isGreaterThanOrEqualTo = firstNumber >= secondNumber;
            Console.WriteLine("{0} is greater than or equal to {1}: {2}", firstNumber, secondNumber, isGreaterThanOrEqualTo);

            //Less than or equal to (<=)
            bool isLessThanOrEqualTo = firstNumber <= secondNumber;
            Console.WriteLine("{0} is less than or equal to {1}: {2}", firstNumber, secondNumber, isLessThanOrEqualTo);
        }

        public static void LogicalOperators()
        {
            bool firstCondition = true;
            bool secondCondition = false;

            //AND (&&)
            bool firstLogic = firstCondition && secondCondition;
            bool secondLogic = firstCondition && firstLogic;
            bool thirdLogic = firstCondition && secondLogic;
            bool forthLogic = secondCondition && firstLogic;
            bool fifthLogic = secondCondition && secondLogic;

            Console.WriteLine("{0} && {1} is: {2}", firstCondition, secondCondition, firstLogic);
            Console.WriteLine("{0} && {1} is: {2}", firstCondition, firstLogic, secondLogic);
            Console.WriteLine("{0} && {1} is: {2}", firstCondition, secondLogic, thirdLogic);
            Console.WriteLine("{0} && {1} is: {2}", secondCondition, firstLogic, forthLogic);
            Console.WriteLine("{0} && {1} is: {2}", secondCondition, secondLogic, fifthLogic);

            //OR (&&)
            bool sixthLogic = firstCondition || secondCondition;
            bool seventhLogic = firstCondition || firstLogic;
            bool eightLogic = firstCondition || secondLogic;
            bool ninthLogic = secondCondition || firstLogic;
            bool tenthLogic = secondCondition || secondLogic;

            Console.WriteLine("{0} || {1} is: {2}", firstCondition, secondCondition, sixthLogic);
            Console.WriteLine("{0} || {1} is: {2}", firstCondition, firstLogic, seventhLogic);
            Console.WriteLine("{0} || {1} is: {2}", firstCondition, secondLogic, eightLogic);
            Console.WriteLine("{0} || {1} is: {2}", secondCondition, firstLogic, ninthLogic);
            Console.WriteLine("{0} || {1} is: {2}", secondCondition, secondLogic, tenthLogic);

            //NOT (!)
            bool eleventhLogic =  !secondCondition;
            bool twelfthLogic = !firstLogic;
            bool thirteenthLogic = !firstCondition;
            bool fourteenthLogic = !secondCondition;
            bool fifteenthLogic = !secondLogic;

            Console.WriteLine("!{0} is: {1}",secondCondition, eleventhLogic);
            Console.WriteLine("!{0} is: {1}",firstLogic, twelfthLogic);
            Console.WriteLine("!{0} is: {1}",firstCondition, thirteenthLogic);
            Console.WriteLine("!{0} is: {1}", secondCondition, fourteenthLogic);
            Console.WriteLine("!{0} is: {1}", secondLogic, fifteenthLogic);
        }
    }
}