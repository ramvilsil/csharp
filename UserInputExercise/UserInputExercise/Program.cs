

//Declares namespace "UserInputExercise"
namespace UserInputExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Writes line on console requesting user input and assigns it to "userInput"s
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();

            //Creates file "filename.txt" and writes the content of "userInput on it
            File.WriteAllText("filename.txt", userInput);

            //Read the contents of "filename.txt" and assigns it to "readText"
            string readText = File.ReadAllText("filename.txt");  
            //Writes "readText" on the console
            Console.WriteLine(readText);
        }
            

    }
}