

namespace methodClassExercise2
{
    //Declares "Program" class
    static class Program
    {
        //Program entry point
        static void Main()
        {
            //Declares string variable "output"
            string outputText;

            //Requests user input, converts it to an int, and assigns it to int variable "userInput"
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt16(Console.ReadLine());

            //Calls method "Method" to update variable "outputText"
            Methods.Method(out outputText);

            //Writes string variable "outputText" as a line on the console
            Console.WriteLine(outputText);

            //Calls method "Method" using variable "userInput" to write
            //the method's math result on the console
            Methods.Method(userInput);

        }
    }
}