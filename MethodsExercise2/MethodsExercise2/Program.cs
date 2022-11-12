

namespace methodsExercise2
{
    //Declares "Program" class
    class Program
    {
        //Program entry point
        static void Main()
        {

            //Requests user input into the console
            Console.WriteLine("Enter a whole number (required):");
            //Converts the value to an int and assigns it to int "num1"
            int num1 = Convert.ToInt16(Console.ReadLine());


            //Requests user input into the console
            Console.WriteLine("Enter a whole number (may leave blank):");
            //Converts the value to an int and assigns it to int "num2"
            try
            {
                //Assigns int "num2" the user input
                int num2 = Convert.ToInt16(Console.ReadLine());
                //Writes line on the console displaying the method "Method" output using "num1" and "num2" as parameters
                Console.WriteLine("\n" + num1 + " + " + num2 + " = " + Methods.Method(num1, num2));

            }

            //(From the user's perspective their input will seem valid as the program is claiming so 
            //But behind the scenes the program must create an exception for the user to enter invalid inputs)

            //Catch block will run upon invalid user input
            catch (Exception)
            {
                //Assigns int "num2" 10 - the default value for "num2" will be 10 when the user enters invalid input
                int num2 = 10;
                //Writes line on the console displaying the method "Method" output using "num1" and "num2" as parameters
                Console.WriteLine("\n" + num1 + " + " + num2 + " = " + Methods.Method(num1, num2));

            }

        }
    }
}