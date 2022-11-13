using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declares namespace "MethodsAndObjects"
namespace MethodsAndObjects
{
    //Creates class "Person"
    public class Person
    {
        //Creates string property "FirstName" 
        public string FirstName { get; set; }

        //Creates string property "LastName" 
        public string LastName { get; set; }    

        //Creates method "SayName"
        public void SayName()
        {
            //Writes line on the console displaing the object's "FirstName" and "LastName" properties
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        

    }
}
