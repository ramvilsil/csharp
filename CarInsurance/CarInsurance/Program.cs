//Declares namespace as "CarInsuranceProgram"
namespace CarInsuranceProgram
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("What is your age?");
            //User input
            int question1 = Convert.ToInt16(Console.ReadLine());
            
            //Question 2
            Console.WriteLine("Have you ever had a DUI? (yes/no)");
            //User input
            string question2 = Console.ReadLine();

            //Question 3 
            Console.WriteLine("How many speeding tickets do you have?");
            //User input
            int question3 = Convert.ToInt16(Console.ReadLine());


            //The boolean value "qualified" is true if the user enters:
            //A number over 15 for their age
            //"no" to having a DUI
            //A number of 3 or less of speeding tickets
            bool qualified = (question1 > 15 && question2 == "no" && question3 <= 3);


            //Writes final line stating whether or not the user is qualified
            Console.WriteLine("Qualified?\r\n" + qualified);
        }
    }
}