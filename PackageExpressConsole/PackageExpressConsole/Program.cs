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

            //Check the package weight, must be below 50
            if (packageWeight < 50)
            {

                //Program requests data from the user for the conditions to be checked 
                Console.WriteLine("Enter the package width:");
                int packageWidth = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter the package height: ");
                int packageHeight = Convert.ToInt16(Console.ReadLine());


                Console.WriteLine("Enter the package length:");
                int packageLength = Convert.ToInt16(Console.ReadLine());

                //Total dimensions of the package are calculated
                int dimensions = packageWidth + packageHeight + packageLength;

                //Check the package dimensions, must be below 50
                if (dimensions < 50)
                {
                    //Calculate the quote
                    int quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                    //Write line displaying the quote
                    //End of program
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\r\nThank you!");
                }
                //Else statement for package dimensions
                //End of program
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");

                }

            }
          
            //Else statement for package weight
            //End of program
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

        }
    }
}