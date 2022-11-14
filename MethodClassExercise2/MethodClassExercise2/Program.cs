

namespace methodClassExercise2
{
    //Declares "Program" class
    static class Program
    {
        //Program entry point
        static void Main()
        {
            //Creates an instancce of the "Method" class called "methods"
            Methods methods = new Methods();

            //Declares string variable "outputText"
            string outputText;

            //Requests user input, converts it to an int, and assigns it to int variable "userInput"
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt16(Console.ReadLine());


            //Calls a "method" object method
            //The method updates the string variable "outputText"
            methods.Method(out outputText);

            //Writes string variable "outputText" as a line on the console
            Console.WriteLine(outputText);

            //Calls a "method" object method with "userInput" as a parameter
            //The method writes the math result on the console
            methods.Method(userInput);

        }
    }
}