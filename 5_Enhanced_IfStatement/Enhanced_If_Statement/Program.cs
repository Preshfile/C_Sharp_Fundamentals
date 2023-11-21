namespace Enhanced_If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name();

            StateOfMatterWithTemperature();
            Console.Read();
        }

        public static void Name()
        {
            string name = "Nkechi";
            string confirmName;

            confirmName  = name.Equals("Nkechi") ? "That is my name" : "Not my name";

            Console.WriteLine(confirmName);
        }
        public static void StateOfMatterWithTemperature()
        {
            int degreeOfTemp = -10;
            string stateOfMatter;

            //traditional if statement
            if (degreeOfTemp < 0)

                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //short if (conditional (ternary) operator)
            stateOfMatter = degreeOfTemp > 0 ? "solid" : "Liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            degreeOfTemp = 110;

            //conditional ternary operator with else if
            stateOfMatter = degreeOfTemp > 100 ? "Gas" : degreeOfTemp > 0 ? "Liquid" : " solid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
        }
    }
}