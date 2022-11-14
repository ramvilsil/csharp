

using System;
//Declares namespace "PolymorphismExercise"
namespace PolymorphismExercise
{
    //Creates class "Employee"
    //inheriting from "Person" class, and from the "IQuittable" interface
    public class Employee : Person, IQuittable
    {
        //Implements method "SayName"
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        //Implements method "Quit"
        public void Quit()
        {
            Console.WriteLine(FirstName +" " + LastName + " quits!");
        }
    }
}