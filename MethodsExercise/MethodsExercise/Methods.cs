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
        public int Method(int intNum)
        {
            //Increments "intNum" value by 10
            intNum += 10;

            //Returns  "intNum" as an int
            return intNum;
        }

        //Uses the same method previously used "Method" - Method overloading
        public int Method(decimal decimalNum)
        {
            //Multiplies "decimalNum" value by 5
            decimalNum *= 5;

            //Creates new int "nonDecimalNum" from "decimalNum" converted to an int
            int nonDecimalNum = Convert.ToInt16(decimalNum);

            //Returns "nonDecimalNum" as an int
            return nonDecimalNum;
        }

        //Uses the same method previously used "Method" - Method overloading
        public int Method(string stringNum)
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
