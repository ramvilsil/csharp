

//Declares namespace "ConstructorExercise"
namespace ConstructorExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {
            //Requests user input for a number and assigns it to a variable created using keyword "var"
            Console.WriteLine("Enter a number");
            var number = Console.ReadLine();
            //Writes the user's input on the console using the same variable
            Console.WriteLine("Your input: " + number);

            //Creates string const "word"
            const string word = "This is a const string";
            //Writes "word" const on the console
            Console.WriteLine(word);

            //Prompts user to enter a username and password
            Console.WriteLine("Register");
            Console.WriteLine("Enter your username");

            //Creates string "username" with the user input
            string username = Console.ReadLine();


            Console.WriteLine("Create a password");

            //Creates string "username" with the user input
            string password = Console.ReadLine();

            //Creates "User" instance called "user" with a constructor method and
            //the "password" string as a parameter
            User user = new User(password);

            //Writes line on the console displaying the "UserName" and "Password" properties of instance "user"
            Console.WriteLine(user.UserName + " " + user.Password);
        }
    }
}