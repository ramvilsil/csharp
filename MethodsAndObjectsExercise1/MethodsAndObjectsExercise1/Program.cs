
//Declares namespace "MethodsAndObjects"
namespace MethodsAndObjects
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Creates an instance of the "Employee" class called "employee"
            Employee employee = new Employee();

            //Assigns properties to the "employee" object
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Calls superclass method "SayName" on the "employee" object
            employee.SayName();
            

        }
    }
}