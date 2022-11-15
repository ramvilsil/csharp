
//Declares namespace "ParsingEnumsExercise"
namespace ParsingEnumsExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Writes line on the console requesting user input
            Console.WriteLine("Enter the current day of the week:");

            //Try block
            try
            {
                //Takes user input as a string, parses it to a "WeekDays" enum element
                //User input must correspond to an element in the "WeekDays" enum
                WeekDays userInput = (WeekDays)Enum.Parse(typeof(WeekDays), Console.ReadLine(), true);

                //Writes line on the console upon valid user input
                Console.WriteLine("Success.");
            }
            //Catch block
            catch (Exception)
            {
                //Writes line on the console upon invalid user input
                Console.WriteLine("Please enter an actual day of the week.");
            }


        }

    }
}