
//Declares the name space as "ArraysExercise"
namespace ArraysExercise
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main()
        {
            //Strings array
            string[] stringArray = new string[5];
            
            //Assigns a value to each index in the array
            stringArray[0] = "five";
            stringArray[1] = "ten";
            stringArray[2] = "fifteen";
            stringArray[3] = "twenty";
            stringArray[4] = "twenty-five";

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter a number from 0-4: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            //Writes a line on the console displaying the corresponding output
            Console.WriteLine("Output: " + stringArray[userInput] + "\n");



            //Integers array
            int[] numArray = new int[5];

            //Assigns a value to each index in the array
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 15;
            numArray[3] = 20;
            numArray[4] = 25;

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter a number from 0-4: ");
            userInput = Convert.ToInt16(Console.ReadLine());

            //Writes a line on the console displaying the corresponding output
            Console.WriteLine("Output: " + numArray[userInput]);

        }
    }
}