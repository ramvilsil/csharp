using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise
{
    //Declares the public class "Methods"
    public class Methods
    {
        //Creates method "Method"
        public static int Method(int intNum)
        {
            //Increments "intNum" value by 10
            intNum += 10;

            //Returns  "intNum" as an int
            return intNum;
        }

        //Uses the same method previously used "Method" - Method overloading
        public static int Method(double doubleNum)
        {
            //Multiplies "doubleNum" value by 5
            doubleNum *= 5;

            //Creates new int "nonDoubleNum" from "doubleNum" converted to an int
            int nonDoubleNum = Convert.ToInt16(doubleNum);

            //Returns "nonDoubleNum" as an int
            return nonDoubleNum;
        }

        //Uses the same method previously used "Method" - Method overloading
        public static int Method(string stringNum)
        {
            //Creates new int "nonStringNum" from "stringNum" as an int
            int nonStringNum = Int16.Parse(stringNum);

            //Divides "nonStringNum" value by 2
            nonStringNum /= 2;

            //Returns "nonStringNum" as an int
            return nonStringNum;
        }

    }
}
