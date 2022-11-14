using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assigns namespace "OperatorOverloadingExercise"
namespace OperatorOverloadingExercise
{
    //Creates class "Employee"
    public class Employee
    {
        //Creates int property "Id"
        public int Id { get; set; }

        //Creates string property "FirstName"
        public string FirstName { get; set; }

        //Creates string property "FirstName"
        public string LastName { get; set; }    

        //Creates == operator overload method using the "Employee" objects
        public static string operator== (Employee employee, Employee employee2)
        {
            //If the object's "Id" properties are equal then a message saying so will be returned
            if (employee.Id == employee2.Id)
            {
                return "The employees have the same id";   
            }

            //If the object's "Id" properties are not found to be equal then a message saying so will be returned
            else
            {
                return "The employees don't have the same id";

            }

        }

        //Creates != operator overload method using the "Employee" objects
        //As comparison operators must be overloaded in pairs
        public static string operator!= (Employee employee, Employee employee2)
        {
            //If the object's "Id" properties are not equal then a message saying so will be returned
            if (employee.Id != employee2.Id)
            {
                return "The employees don't have the same id";
            }

            //If the object's "Id" properties are not found to be not equal then a message saying so will be returned
            else
            {
                return "The employees have the same id";

            }
        }

    }
}
