

namespace methodClassExercise1
{
    //Declares "Program" class
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Defines "num1" and "num2" int variables
            int num1 = 0;
            int num2 = 0;

            //Creates an instance of the "Methods" class called "myMethod"
            Methods myMethod = new Methods();

            //Calls method "Method" from the "Methods" class and uses 2 int values as the parameters
            Methods.Method(1, 1);

            //Calls method "Method" from the "Methods" class and uses 2 predefined int variables as the parameters
            Methods.Method(num1, num2);


        }
    }
}