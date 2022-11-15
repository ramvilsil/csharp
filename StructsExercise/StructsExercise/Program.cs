

//Declares namespace "StructsExercise"
namespace StructsExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Creates instance "number" of struct "Number"
            Number number = new Number();

            //Assigns value to "Amount" property value of "number"
            number.Amount = 10.0m;

            //Writes line displaying "Amount" property value of "number"
            Console.WriteLine(number.Amount);
        }
    }
        

}