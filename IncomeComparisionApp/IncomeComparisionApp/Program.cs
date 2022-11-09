//Declares namespace as "IncomeComparison"
namespace IncomeComparison
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main(string[] args)
        {
            //Writes introductory line on the console
            Console.WriteLine("Anonymous Income Comparison Program");


            //Person 1's Questions
            //Writes lines on the console
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");

            //Reads the line of characters from the user's input into the console and assigns it to an integer variable
            int hourlyRate1 = Convert.ToInt16(Console.ReadLine());

            //Writes line on the console
            Console.WriteLine("Hours worked per week?");
            //Reads the line of characters from the user's input into the console and assigns it to an integer variable
            int weeklyHours1 = Convert.ToInt16(Console.ReadLine());


            //Person 2's Questions
            //Writes lines on the console
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");

            //Reads the line of characters from the user's input into the console and assigns it to an integer variable
            int hourlyRate2 = Convert.ToInt16(Console.ReadLine());

            //Writes line on the console
            Console.WriteLine("Hours worked per week?");
            //Reads the line of characters from the user's input into the console and assigns it to an integer variable
            int weeklyHours2 = Convert.ToInt16(Console.ReadLine());


            //Annual Salary Calculations
            
            //Defines the number of weeks in a full year
            int weeksPerYear = 52;

            //Multiplies the person's hourly rate by their weekly hours and the number of weeks in a full year
            int annualSalary1 = hourlyRate1 * weeklyHours1 * weeksPerYear;

            int annualSalary2 = hourlyRate2 * weeklyHours2 * weeksPerYear;


            //Determines whether Person 1's annual salary is greater than Person 2's and assigns the boolean to a variable
            bool trueOrFalse = annualSalary1 > annualSalary2;


            //Writes lines with the annual salaries of both people
            Console.WriteLine("Annual salary of Person 1:\r\n$" + annualSalary1);

            Console.WriteLine("Annual salary of Person 1:\r\n$" + annualSalary2);

            //Writes line saying whether or not it's true person 1's annual salary is greater
            Console.WriteLine("Does Person 1 make more money than Person 2?\r\n" + trueOrFalse);


        }
    }
}