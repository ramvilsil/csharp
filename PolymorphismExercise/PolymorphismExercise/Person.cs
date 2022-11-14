using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declares namespace "PolymorphismExercise"
namespace PolymorphismExercise
{
    //Creates abstract class "Person"
    public abstract class Person
    {
        //Creates string property "FirstName" 
        public string FirstName { get; set; }

        //Creates string property "LastName" 
        public string LastName { get; set; }

        //Declares method "SayName"
        void SayName()
        {

        }

    }
}