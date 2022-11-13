using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declares namespace "AbstractClassExercise"
namespace AbstractClassExercise
{
    //Creates class "Employee" inheriting from "Person" class
    public class Employee : Person
    {   
        //Creates and implements method "SayName"
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
