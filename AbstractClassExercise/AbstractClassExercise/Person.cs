using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declares namespace "AbstractClassExercise"
namespace AbstractClassExercise
{
    //Creates class "Person"
    public abstract class Person
    {
        //Creates string property "FirstName" 
        public string FirstName { get; set; }

        //Creates string property "LastName" 
        public string LastName { get; set; }

        //Creates method "SayName"
        public void SayName()
        {
          
        }

    }
}