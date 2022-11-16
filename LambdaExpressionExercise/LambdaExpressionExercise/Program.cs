

//Assigns namespace "LambdaExpressionExercise"
namespace LambdaExpressionExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {

            //Writes line on the console - clarifies to the user the following data to be printed
            Console.WriteLine("\nAll employees:");

            //Creates an instance of the Random class called "random" which represents a pseudo-random number generator
            Random random = new Random();

            //Creates string list "possibleNames"
            List<string> possibleNames = new List<string>();

            //Adds strings to list "possibleNames" - each string represents a possible first name
            //for the "FirstName" property of the "Employee" class objects
            possibleNames.Add("Chris");
            possibleNames.Add("Ed");
            possibleNames.Add("Josh");
            possibleNames.Add("James");
            possibleNames.Add("Mike");
            possibleNames.Add("Andrew");
            possibleNames.Add("Joe");


            //Creates "Employee" type list "employeesList"
            List<Employee> employeesList = new List<Employee>();

            //For loop consisting of 8 iterations for a total of 8 "Employee" objects to be created in this loop
            //Aims to create 8 "Employee" class objects and assign them an "Id" property
            //As well as a "FirstName" property
            for (int i = 0; i < 8; i++)
            {
                //Creates instance of the "Employee" class called "employee"
                Employee employee = new Employee();
                //Every "Employee" object created in this loop will be added to "employeesList"


                //Assigns the int "Id" property to the "Employee" object 
                //The id is going to be the amount of items in the "employeesList" list
                //in the moment in which the object is created
                //Each object added to "employeesList" will have a greater "Id"
                //property value than the one found in the previous index
                employee.Id = employeesList.Count;

                //Assigns the string "FirstName" property to the "Employee" object
                //The first name of each employee will be a string value from the "possibleNames" list
                //This is implemented by generating a random integer between 0 and the amount of items in
                //"possibleNames", these 2 values represent the range of indices of the items in the
                //"possibleNames" list
                employee.FirstName = possibleNames[random.Next(0, possibleNames.Count)];

                //The "Employee" object is added to "employeesList"
                employeesList.Add(employee);

            }

            //For loop consisting of 2 iterations for a total of 2 "Employee" objects to be created in this loop
            //Aims to create 2 "Employee" class objects and assign them an "Id" and "FirstName" property
            //The purpose of this loop is to secure 2 "Employee" objects with the "FirstName" property
            //value of the string "Joe"
            //As the previously loop assigns random first names and does not guarentee 2 employees named Joe
            //which is our goal
            for (int i = 0; i < 2; i++)
            {
                //Creates instance of the "Employee" class called "employee"
                Employee employee = new Employee();

                //Assigns the int "Id" property to the "Employee" object
                //- this is implemented like in the previous for loop
                employee.Id = employeesList.Count;

                //Assigns the string "FirstName" property to the "Employee" object
                //The first name of each employee will be the string value "Joe" every time
                employee.FirstName = "Joe";

                //The "Employee" object is added to "employeesList"
                employeesList.Add(employee);

            }

            //Each "Employee" object in "employeesList" properties "Id" and "FirstName"
            //are written on their own line on the console
            //Abstract idea: displays the id of every employee along with their first name
            foreach (Employee employee in employeesList)
            {
                Console.WriteLine("Id: "+ employee.Id + " | First Name: " + employee.FirstName);
            }


            //Writes line on the console - clarifies to the user the following data to be printed
            Console.WriteLine("\nEmployees named Joe:");

            //Creates "Employee" type list "JoeEmployees"
            List<Employee> JoeEmployees = new List<Employee>();

            //Each "Employee" object in "employeesList" which has the "FirstName" property
            //equal to string "Joe" is added to the list "JoeEmployees"
            foreach (Employee employee in employeesList)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeEmployees.Add(employee);
                }

            }

            //Each "Employee" object in "JoeEmployees" has their "FirstName" property
            //written on a line on the console
            //Abstract idea: displays the name of every employee named Joe each on their own line
            for (int i = 0; i < JoeEmployees.Count; i++)
            {
                Console.WriteLine(JoeEmployees[i].FirstName);

            }

            //Creates int using lambda expression - gets the amount of items in "employeesList" 
            //which have the "FirstName" property equal to "Joe"
            int JoeEmployeesAmount = employeesList.Where(x => x.FirstName == "Joe").Count();

            //Writes line on the console displaying "JoeEmployeesAmount"
            //Abstract idea: tells the user the amount of employees named Joe on a line
            Console.WriteLine("There are " + JoeEmployeesAmount + " employees named Joe.");
            

            //Writes line on the console - clarifies to the user the following data to be printed
            Console.WriteLine("\nEmployees with an id number over 5:");


            //Creates "Employee" type list "employeeIdOver5"
            List<Employee> employeeIdOver5 = new List<Employee>();

            //Each "Employee" object in "employeesList" which has their "Id" property
            //greater than 5 is added to the list "employeeIdOver5"
            //Hence "empolyeeIdOver5" list is a list that consists of every
            //"Employee" class object which "Id" is greater than 5
            foreach (Employee employee in employeesList.Where(x => x.Id > 5))
            {
                employeeIdOver5.Add(employee);
            }

            //Each "Employee" object in "employeeIdOver5" has their "FirstName" property
            //written on a line on the console
            //Abstract idea: displays the names of employees with an id greater than 5 each on their own line
            for (int i = 0; i < employeeIdOver5.Count; i++)
            {
                Console.WriteLine(employeeIdOver5[i].FirstName);

            }


        }
    }
}


