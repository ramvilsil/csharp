
//Declares the name space as "ArraysExercise"
namespace ArraysExercise
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main()
        {
            //Strings array
            string[] stringArray = new string[5];
            
            //Assigns a value to each index in the array
            stringArray[0] = "five";
            stringArray[1] = "ten";
            stringArray[2] = "fifteen";
            stringArray[3] = "twenty";
            stringArray[4] = "twenty-five";

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter a number from 0-4: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            //Creates boolean to check if the user enters an invalid number
            bool inArray = false;

            //Iterates through every index in the "stringArray"
            //Boolean "inArray" will be assigned true if a valid number is entered
            for (int i = 0; i < stringArray.Length; i++)
            {
                //Compares each index in the array to the user input
                if (i == userInput)
                {
                    //Writes the line on the console
                    Console.WriteLine("Output: " + stringArray[userInput] + "\n");
                    
                    //If the program reaches this point "inArray" becomes true
                    //Prevents error message from being thrown
                    inArray = true;

                }

            //Checks if the "inArray" boolean value is false
            //i.e. the value will be false if the program never found a match between the array index and the user input
            }
            if (inArray == false)
            {
                //Writes error message
                Console.WriteLine("You entered an invalid number");

            }


            //Integers array
            int[] numArray = new int[5];

            //Assigns a value to each index in the array
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 15;
            numArray[3] = 20;
            numArray[4] = 25;

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter a number from 0-4: ");
            userInput = Convert.ToInt16(Console.ReadLine());

            //Reasigns boolean to check if the user enters an invalid number
            inArray = false;


            //Iterates through every index in the "numArray"
            //Boolean "inArray" will be assigned true if a valid number is entered
            for (int i = 0; i < numArray.Length; i++)
            {
                //Compares each index in the array to the user input
                if (i == userInput)
                {
                    //Writes the line on the console
                    Console.WriteLine("Output: " + numArray[userInput]);

                    //If the program reaches this point "inArray" becomes true
                    //Prevents error message from being thrown
                    inArray = true;

                }

            //Checks if the "inArray" boolean value is false
            //i.e. the value will be false if the program never found a match between the array index and the user input
            }
            if (inArray == false)
            {
                //Writes error message
                Console.WriteLine("You entered an invalid number");

            }

            //Creates string list "namesList"
            List<string> namesList = new List<string>();

            //Adds names to the list in the form of strings
            namesList.Add("Jake");
            namesList.Add("Carl");
            namesList.Add("Elizabeth");
            namesList.Add("Kate");
            namesList.Add("Bob");

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter a number from 0-4: ");
            userInput = Convert.ToInt16(Console.ReadLine());


            //Creates boolean to check if the user enters an invalid number
            bool inList = false;

            //Iterates through every index in the "namesList"
            //Boolean "inList" will be assigned true if a valid number is entered
            for (int i = 0; i < namesList.Count; i++)
            {
                if (i == userInput)
                {
                    //Writes the line on the console
                    Console.WriteLine("The person's name at this index is " + namesList[userInput] + ".");

                    //If the program reaches this point "inList" becomes true
                    //Prevents error message from being thrown
                    inList = true;

                }

            }

            //Checks if the "inList" boolean value is false
            //i.e. the value will be false if the program never found a match between the array index and the user input
            if (inList == false)
            {
                //Writes error message
                Console.WriteLine("You entered an invalid number");

            }


        }
    }
}