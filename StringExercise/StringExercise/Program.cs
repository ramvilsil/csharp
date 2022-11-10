
//Program calls the "System.Text" namespace
using System.Text;

//Declares the name space as "StringExercise"
namespace StringExercise
{
    //Declares the class as "Program:
    class Program
    {
        //Program entry point
        static void Main(string[] args)
        {
            //Creates a string through concatenation and assigns it to the variable "numbers"
            string numbers = ("One " + "Two " + "Three ");

            //Writes the string assigned to "numbers" on the console
            Console.WriteLine(numbers.ToUpper());

            //Creates a string builder with the variable name "sb"
            StringBuilder sb = new StringBuilder();

            //Appends lines to the string builder "sb"
            sb.AppendLine("--------");
            sb.AppendLine("Welcome.");
            sb.AppendLine("This program was made for educational purposes.");
            sb.AppendLine("The date today is 11/10/2022.");
            sb.AppendLine("New Year's Eve will be in 51 days.");

            //Writes "sb" Stringbuilder on the console
            Console.WriteLine(sb);
        }

    }
}