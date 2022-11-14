

namespace methodsExercise
{
    //Declares "Program" class
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Creates Methods class instance "method"
            Methods method = new Methods();


            //Requests user input into the console
            Console.WriteLine("Enter a whole number to increment by 10:");
            //Converts the value to an int and assigns it to int "intNum"
            int intNum = Convert.ToInt16(Console.ReadLine());

            //Writes line on the console displaying the  object "method" method  output using "intNum" as a parameter
            Console.WriteLine(method.Method(intNum));


            //Requests user input into the console
            Console.WriteLine("Enter a decimal number to multiply by 5:");
            //Converts the value to a decimal and assigns it to decimal "decimalNum"
            decimal decimalNum = Convert.ToDecimal(Console.ReadLine());

            //Writes line on the console displaying the  object "method" method  output using "decimalNum" as a parameter
            Console.WriteLine(method.Method(decimalNum) + " (displayed as a whole number)");


            //Requests user input into the console
            Console.WriteLine("Enter a whole number to divide by 2:");
            //Assigns the value to string "stringNum"
            string stringNum = Console.ReadLine();

            //Writes line on the console displaying the  object "method" method  output using "stringNum" as a parameter
            Console.WriteLine(method.Method(stringNum));

            
        }
    }
}