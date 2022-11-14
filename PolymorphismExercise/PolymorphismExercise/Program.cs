

//Declares namespace "PolymorphismExercise"
namespace PolymorphismExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {

            //Creates an object of the "Employee" class called "employee"
            Employee employee = new Employee();

            //Creates an interface object type "IQuittable" called "quittable" using "Employee" class object "employee"
            IQuittable quittable = employee;


            //Assigns properties to the "employee" object
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Calls method "SayName" on the "employee" object
            employee.SayName();

            //Calls method "Quit" on the "quittable" object
            quittable.Quit();


        }
    }
}