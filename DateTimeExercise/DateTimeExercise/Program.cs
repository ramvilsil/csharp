
//Declares namespace "DateTimeExercise"
namespace DateTimeExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Creates "DateTime" type instance called "dateTime" and assigns it the "Now" property
            DateTime dateTime = DateTime.Now;

            //Writes line on the console displaying "dateTime"
            Console.WriteLine(dateTime);

            //Requests user input, converts it to an int and assigns to "userInput"
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Updates "dateTime" with the "Now" property
            dateTime = DateTime.Now;
            //Increments dateTime "Hours" property by the "userInput" value using the "AddHours" method
            dateTime = dateTime.AddHours(userInput);

            //Writes line on the console displaying the new "dateTime" 
            Console.WriteLine("It will be " + dateTime + " in " + userInput + " hours.");
        }
    }
}