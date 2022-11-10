//Declares namespace as "ShippingQuote"

namespace ShippingQuote
{
    //Declares the class "Program"
    class Program
    {
        //Defines the program entry point
        static void Main(string[] args)
        {

            //Introductory line
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Program requests input from the user for the first condition to be checked 
            Console.WriteLine("Enter the package weight:");
            int packageWeight = Convert.ToInt16(Console.ReadLine());
            
            //#1 if statement, check the package weight, must be below 50
            if (packageWeight < 50)
            {
                Console.WriteLine("Enter the package width:");
                //#2 if statement, check the package width, must be below 50
                int packageWidth = Convert.ToInt16(Console.ReadLine());
                if (packageWidth < 50)
                {

                    Console.WriteLine("Enter the package height: ");
                    int packageHeight = Convert.ToInt16(Console.ReadLine());

                    //#3 if statement, check the package height, must be below 50
                    if (packageHeight < 50)
                    {
                        Console.WriteLine("Enter the package length:");
                        int packageLength = Convert.ToInt16(Console.ReadLine());

                        //#4 if statement, check the package length, must be below 50
                        if (packageLength < 50)
                        {
                            //Calculate the quote
                            int quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                            
                            //Write line displaying the quote
                            //End of program
                            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\r\nThank you!");
                        }

                        //#4 else statement for package length
                        else
                        {
                            Console.WriteLine("Package too long to be shipped via Package Express. Have a good day.");
                        }

                    }
                    //#3 else statement for package height
                    else
                    {
                        Console.WriteLine("Package too tall to be shipped via Package Express. Have a good day.");
                    }

                }
                //#2 else statement for package width
                else
                {
                    Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day.");
                }

            }

            //#1 else statement for package weight
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

        }
    }
}