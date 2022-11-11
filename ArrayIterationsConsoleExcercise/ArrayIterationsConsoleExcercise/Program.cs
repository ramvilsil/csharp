

using System.Data;
//Creates namespace "ArrayIterationsExercise"
namespace ArrayIterationsExercise
{
    //Creates class "Program"
    class Program
    {
        //Program entry point
        static void Main()
        {

            //Part 1

            Console.WriteLine("-------\nPart 1\n-------");

            //Creates array "stringsArray" and assigns 5 values (index 0-4)
            string[] stringsArray = { "1: ", "2: ", "3: ", "4: ", "5: " };

            //Requests the user input and assigns it to the variable "word"
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine() + "\n";

            //Iterates through each item in the array "stringsArray"
            for (int i = 0; i < stringsArray.Length; i++)
            {
                //The user's input is added to the end of each string in the array "stringsArray"
                stringsArray[i] = stringsArray[i] + word;
            }

            //Iterates through each item in the array "stringsArray"
            for (int i = 0; i < stringsArray.Length; i++)
            {
                //Writes each item in the "stringsArray" array as a line on the console
                Console.WriteLine(stringsArray[i]);
            }


            //Part 2

            Console.WriteLine("-------\nPart 2\n-------");

            //Creates "num" int variable
            int num = 0;

            //Creates "running" boolean variable
            bool running = true;

            //While loop runs while "running" is true
            while (running)
            {
                //The line will be written on the console while running is true
                Console.WriteLine(num + "\n");

                //Increments the value of "num" by 1 while running is true
                num++;

                //Program will branch into this statement when "num" is equal to 10
                if (num == 10)
                {
                    //"Running" is assigned false
                    //The while loop will end at this point
                    //Prevents an infinite while loop
                    running = false;
                }
            }


            //Part 3

            Console.WriteLine("-------\nPart 3\n-------");

            //Reassigns "num" variable
            num = 40;

            //Reassigns string "outputText"
            string outputText = "Hello World! ";

            //Reassigns "running" to true
            running = true;

            //While loop runs while "running" is true
            while (running)
            {
                //The line will be written on the console while running is true
                Console.WriteLine(outputText + num + "\n");

                //Decrements the value of "num" by 1 while running is true
                num--;

                //Program will branch into this statement if "num" reaches a value less than 20
                if (num < 20)
                {
                    //"Running" is assigned false
                    //The while loop will end at this point
                    //Prevents an infinite while loop
                    running = false;
                }
            }

            //Reassigns "num" variable
            num = 100;

            //Reassigns string "outputText"
            outputText = "Goodbye World. ";

            //Reassigns "running" to true
            running = true;

            //While loop runs while "running" is true
            while (running)
            {
                //The line will be written on the console while running is true
                Console.WriteLine(outputText + num + "\n");

                //Decrements the value of "num" by 20 while running is true
                num -= 20;

                //Program will branch into this statement if "num" reaches a value less than  or equal to 20
                if (num <= 20)
                {
                    //"Running" is assigned false
                    //The while loop will end at this point
                    //Prevents an infinite while loop
                    running = false;
                }
            }


            //Part 4

            Console.WriteLine("-------\nPart 4\n-------");

            //Creates string list "animalNamesList"
            List<string> animalNamesList = new List<string>();

            //Adds animal names to the list in the form of strings
            animalNamesList.Add("dog");
            animalNamesList.Add("cat");
            animalNamesList.Add("pig");
            animalNamesList.Add("horse");
            animalNamesList.Add("sheep");
            animalNamesList.Add("hen");
            animalNamesList.Add("rooster");
            animalNamesList.Add("goat");

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter the name of your favorite farm animal:");
            string userInput = Console.ReadLine();
            

            //Creates boolean to track if the user's input is not found in the list
            bool inList = false;

            //Iterates through every index in the "animalNamesList"
            //Boolean "inList" will be assigned true if valid input is entered
            for (int i = 0; i < animalNamesList.Count; i++)
            {

                //Checks if the item in the list matches the user's input
                if (animalNamesList[i] == userInput.ToLower())
                {
                    //Writes the line on the console
                    Console.WriteLine("The index of this farm animal is " + i + ".");

                    //If the program reaches this point "inList" becomes true
                    //Prevents error message from being thrown
                    inList = true;
                    
                }

            }

            //Checks if the "inList" boolean value is false
            //i.e. the value will be false if the program never found a match between the value at the index and the user input
            if (inList == false)
            {
                //Writes error message
                Console.WriteLine("You entered a farm animal that is not in the list.");

            }






            //Part 5

            Console.WriteLine("-------\nPart 5\n-------");

            //Creates a new string list "colorsList"
            List<string> colorsList = new List<string>();

            //Adds colors to the list in the form of strings
            colorsList.Add("blue");
            colorsList.Add("blue");
            colorsList.Add("red");
            colorsList.Add("green");
            colorsList.Add("white");
            colorsList.Add("black");
            colorsList.Add("orange");
            colorsList.Add("purple");
            colorsList.Add("yellow");
            colorsList.Add("yellow");

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter your favorite color:");
            userInput = Console.ReadLine();


            //Reassigns boolean to track if the user's input is found in the list
            inList = false;

            //Iterates through every item in the "colorsList"
            //Boolean "inList" will be assigned true if a valid number is entered
            for (int i = 0; i < colorsList.Count; i++)
            {
                //Checks if the item in the list matches the user's input
                if (colorsList[i] == userInput.ToLower())
                {

                    //The program will branch into this if statement if the item in the list matches the user input
                    //and it has not been previously found in the list
                    if (inList == false)
                    {
                        //Writes the output line
                        Console.WriteLine("This color's index in the list is " + i + ".");
                    }
                    //The program will branch into this else statement if the item in the list matches the user input
                    //and it has been previously found in the list
                    else
                    {
                        Console.WriteLine("This color can also be found at the index of " + i + ".");
                    }

                    //If the program reaches this point "inList" becomes true
                    //This will prevent an error message from being thrown
                    //As well as indicate the item appears in the list at least once
                    inList = true;

                }

            }

            //Checks if the "inList" boolean value is false
            //i.e. the value will be false if the program never found a match between the value at the index and the user input
            if (inList == false)
            {
                //Writes error message
                Console.WriteLine("The color you entered is not in the list.");

            }





            //Part 6

            Console.WriteLine("-------\nPart 6\n-------");

            //Creates a new string list "lettersList"
            List<string> lettersList = new List<string>();

            //Adds letters to the list in the form of strings
            lettersList.Add("a");
            lettersList.Add("a");
            lettersList.Add("a");
            lettersList.Add("b");
            lettersList.Add("c");
            lettersList.Add("c");
            lettersList.Add("c");
            lettersList.Add("c");
            lettersList.Add("d");
            lettersList.Add("e");
            lettersList.Add("f");
            lettersList.Add("f");
            lettersList.Add("g");
            lettersList.Add("h");
            lettersList.Add("i");
            lettersList.Add("j");

            //Requests the user input and assigns it to the variable "userInput"
            Console.WriteLine("Enter a letter (a-j):");
            userInput = Console.ReadLine();


            bool unique = true;

            //Creates boolean to check if the user enters an invalid number
            bool inListOnce = false;

            int appearances = 0;

            //Iterates through every index in the "lettersList"
            for (int i = 0; i < lettersList.Count; i++)
            {
                //Checks if the item in the list matches the user's input
                if (lettersList[i] == userInput.ToLower())
                {

                    //If the item appears in the list once "inListOnce" will be true
                    if (inListOnce == true)
                    {
                        //Reaching this point will indicate an additional appearance, "unique" will become false
                        unique = false;

                        //Takes count of each time the item appears in the list
                        appearances++;

                        //Writes the output line
                        Console.WriteLine(userInput + " - this letter appears again in the list for a total of " + appearances + " appearances.");
                    }



                    //If the program reaches this point "inListOnce" becomes true
                    //Prevents error message from being thrown later in the program
                    inListOnce = true;

                }

            }

            //If "unique" turns out to be true its corresponding output line is written
            if (unique == true)
            {
                Console.WriteLine(userInput + " - this letter only appears once in the list.");
            }

            //Checks if the "inListOnce" boolean value is false
            //i.e. the value will be false if the program never found a match between the value at the index and the user input
            if (inListOnce == false)
            {
                //Writes error message
                Console.WriteLine("The letter you entered is not in the list.");

            }

            Console.WriteLine("-------\nEnd of program.\n-------");

        }

    }
}