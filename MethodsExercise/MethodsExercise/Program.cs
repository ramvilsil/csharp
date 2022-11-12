

namespace methodsExercise
{
    //Declares "Program" class
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Requests user input into the console
            Console.WriteLine("Enter a whole number to increment by 10:");
            //Converts the value to an int and assigns it to int "intNum"
            int intNum = Convert.ToInt16(Console.ReadLine());

            //Writes line on the console displaying the method "Method" output using "intNum" as a parameter
            Console.WriteLine(Methods.Method(intNum));


            //Requests user input into the console
            Console.WriteLine("Enter a decimal number to multiply by 5:");
            //Converts the value to a double and assigns it to double "doubleNum"
            double doubleNum = Convert.ToDouble(Console.ReadLine());

            //Writes line on the console displaying the method "Method" output using "doubleNum" as a parameter
            Console.WriteLine(Methods.Method(doubleNum) + " (displayed as a whole number)");


            //Requests user input into the console
            Console.WriteLine("Enter a whole number to divide by 2:");
            //Assigns the value to string "stringNum"
            string stringNum = Console.ReadLine();

            //Writes line on the console displaying the method "Method" output using "stringNum" as a parameter
            Console.WriteLine(Methods.Method(stringNum));
        }
    }
}