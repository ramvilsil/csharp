
//Assigns namespace "OperatorOverloadingExercise"
namespace OperatorOverloadingExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {


            //Creates "Employee" class objects
            Employee employee = new Employee();
            Employee employee2 = new Employee();

            //Defines "Id" properties of the "Employee" objects using the user's input
            Console.WriteLine("Enter an id for Employee 1 (must be a whole number)");
            employee.Id = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter an id for Employee 2 (must be a whole number)");
            employee2.Id = Convert.ToInt16(Console.ReadLine());

            //Defines "FirstName" and "LastName" properties of the "Employee" objects
            employee.FirstName = "Test1";
            employee2.FirstName = "Test2";

            employee.LastName = "Sample1";
            employee2.LastName = "Sample2";

            //Writes line on the console using operator overload method return value
            Console.WriteLine(employee == employee2);

        }
    }
}