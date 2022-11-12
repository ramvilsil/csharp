

using CallingMethodsExercise;

namespace callingMethods
{
    //Defines class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Requests input from the user and assigns it to int variable "userInput"
            Console.WriteLine("Enter a number");
            int userInput = Convert.ToInt16(Console.ReadLine());

            //Writes a line on the console displaying the math operation undertaken by the method
            Console.WriteLine(userInput + " + 1 = " + Methods.Method1(userInput));

            Console.WriteLine(userInput + " - 1 = " + Methods.Method2(userInput));

            Console.WriteLine(userInput + " x 2 = " + Methods.Method3(userInput));



        }



    }
}