
//Declares namespace as "DailyReports"
namespace DailyReports
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main(string[] args)
        {
            //Writes introductory lines on the console
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            //Writes line on the console
            Console.WriteLine("What is your name?");
            //Reads the line of characters from the user's input into the console and assigns it to a string variable
            string userName = Console.ReadLine();

            //Writes line on the console
            Console.WriteLine("What course are you on?");
            //Reads the line of characters from the user's input into the console and assigns it to a string variable
            string currentCourse = Console.ReadLine();

            //Writes line on the console
            Console.WriteLine("What page number?");
            //Reads the line of characters from the user's input into the console and assigns it to an integer variable
            //The user's input is casted from a string to a 32-bit signed integer
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            //Writes line on the console
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.");
            //Reads the line of characters from the user's input into the console and assigns it to a boolean variable
            //The user's input is casted from a string to a boolean
            bool helpNeeded = Convert.ToBoolean(Console.ReadLine());

            //Writes line on the console
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            //Reads the line of characters from the user's input into the console and assigns it to a string variable
            string postiveExperience = Console.ReadLine();

            //Writes line on the console
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //Reads the line of characters from the user's input into the console and assigns it to a string variable
            string feedBack = Console.ReadLine();

            //Writes line on the console
            Console.WriteLine("How many hours did you study today?");
            //Reads the line of characters from the user's input into the console and assigns it to a string variable
            string studyHours = Console.ReadLine();

            //Writes the final line on the console
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            //Reads a line of characters from the user's input into the console
            Console.ReadLine();
        }
    }
}