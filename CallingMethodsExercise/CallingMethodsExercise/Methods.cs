using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsExercise
{
    //Defines class "Methods"
    public class Methods
    {
        //1st Method
        //Creates method that takes the int variable "userInput" as a parameter
        public static int Method1(int userInput)
        {
            //Performs math operation on "userInput" - adds 1
            userInput++;

            //Returns "userInput" argument
            return userInput;
        }

        //2nd Method
        //Creates method that takes the int variable "userInput" as a parameter
        public static int Method2(int userInput)
        {
            //Performs math operation on "userInput" - subtracts 1
            userInput--;

            //Returns "userInput" argument
            return userInput;
        }

        //3rd Method
        //Creates method that takes the int variable "userInput" as a parameter
        public static int Method3(int userInput)
        {
            //Performs math operation on "userInput" - multiplies by 2
            userInput *= 2;

            //Returns "userInput" argument
            return userInput;
        }
    }
}
