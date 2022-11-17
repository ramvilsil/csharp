

//Declares namespace "TryCatchExercise"
namespace TryCatchExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Creates "DateTime" type instance called "dateTime" and assigns it the "Now" property
            DateTime dateTime = DateTime.Now;

            //Asks user to enter their age and attempts to assign the value to int "userAge"
            Console.WriteLine("Enter your age");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                //Subtracts "dateTime"'s year property by the user input assigned to "userAge"
                dateTime = dateTime.AddYears(-userAge);

                //if the user enters a number less than 0 or greater than 150 
                //The error message "InvalidNumberException" is thrown
                if (userAge < 0 || userAge > 150)
                {
                    throw new InvalidNumberException();
                }

                //If the program makes it past the previous if block 
                //then the following line is written on the console - program used as intended
                Console.WriteLine("You were born in " + dateTime.Year);

            }
            
            //Catches if the user specifically entered an invalid number (from the if block in the try block)
            catch (InvalidNumberException)
            {
                //Notifies the user of the issue and ends the main method
                Console.WriteLine("You entered an invalid number for your age! - Program terminates here");
                Console.ReadLine();
                return;
            }

            //Catches if the user entered any other invalid input
            catch (Exception)
            {
                //Notifies the user of the issue and ends the main method
                Console.WriteLine("You entered invalid input! - Program terminates here");
                Console.ReadLine();
                return;
            }
        }
    }
}
