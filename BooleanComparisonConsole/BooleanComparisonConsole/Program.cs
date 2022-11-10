//Declares namespace as "BooleanComparison"
namespace BooleanComparison
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main(string[] args)
        {
            //Declares the variable "number" an integer assigned a value of 1
            int number = 1;

            //Performs block of code while number is less than 5
            do
            {
                //Writes a line displaying the number
                Console.WriteLine(number);
                //Increment number by 1 each line
                number++;
            }
            while (number < 5);

            //While the "number" variable value is less than or equal to 100 write line
            //displaying the number and increment the number by 10 each time
            while (number <= 100)
            {
                Console.WriteLine(number);
                //Increment number by 10 each line
                number += 10;
            }
        }
            
    }
}