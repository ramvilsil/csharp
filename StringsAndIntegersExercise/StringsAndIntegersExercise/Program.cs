
//Defines namespace "StringsAndIntegersExercise"
namespace StringsAndIntegersExercise
{
    //Defines class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {

            //Creates new int list "intList"
            List<int> intList = new List<int>();

            //Adds int values to "intList"
            intList.Add(5);
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            //Try block
            try
            {
                //Requests user input
                Console.WriteLine("Enter a number to divide by:")
                //Assigns user input to "userInput" after conversion to int
    ;           int userInput = Convert.ToInt16(Console.ReadLine());

                //Iterates through each index in "intList"
                for (int i = 0; i < intList.Count; i++)
                    {
                        //Writes a line on the console
                        //Each line displaying a value in the list divided by the user input
                        Console.WriteLine(intList[i] / userInput);
                    }
            }

            //Any errors - invalid data entries made by the user will trigger the catch block
            catch (Exception ex)
            {
                //Writes a line on the console for the issue that emerged in the previous try block
                Console.WriteLine(ex.Message);
            }

           
            

        }
    }
}