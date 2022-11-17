using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declares namespace "ConstructorExercise"
namespace ConstructorExercise
{
    //Creates class "User"
    public class User
    {
        //Creates "User" properties
        public string UserName { get; set; }

        public string Password { get; set; }



        //Calls the other constructor and passes the properties "Person" and password
        //If no string "username" parameter is given at the time the method is called
        //then the string "Person" will be passed as a default value
        public User(string password) : this("Person", password)
        {

        }

        //All properties are orignally passed
        public User(string username, string password)
        {
            //Object properties are defined with the arguments
            UserName = username;
            Password = password;

        }



    }
}
