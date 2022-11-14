using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClassExercise2

{
    //Declares the public class "Methods"
    public class Methods
    {
        //Creates method "Method"
        public void Method(int userInput)
        {
            //Divides userInput by 2

            userInput /= 2;

            //Writes "userInput" on the console
            Console.WriteLine(userInput);

        }

        //Overload method "Method" takes out parameter "outputText"
        public void Method(out string outputText)
        {
            //Updates "outputText" value
            outputText = "Your number divided by 2 equals: ";
        }


    }
}