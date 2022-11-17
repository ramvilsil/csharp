using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

//Declares namespace "TryCatchExercise"
namespace TryCatchExercise
{
    //Creates class for the invalid number exception called "InvalidNumberException" 
    //inheriting from the "Exception" class
    public class InvalidNumberException : Exception
    {

        public InvalidNumberException()
            : base() { }    
        public InvalidNumberException(string message) : base(message) { }


    }
}
