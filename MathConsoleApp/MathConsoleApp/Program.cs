
namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes the user input, multiplies it by 50, and writes the result on the console
            int userInput = Convert.ToInt32(Console.ReadLine());
            int mathProduct = userInput * 50;
            Console.WriteLine(userInput + " times 50 equals " + mathProduct);

            //Takes the user input, adds 25 to it, and writes the result on the console
            userInput = Convert.ToInt16(Console.ReadLine());
            int mathSum = userInput + 25;
            Console.WriteLine(userInput + " plus 25 equals " + mathSum);

            //Takes the user input, divides it by 12.5, and writes the result on the console
            userInput = Convert.ToInt16(Console.ReadLine());
            double mathQuotient = userInput / 12.5;
            Console.WriteLine(userInput + " divided by 12.5 equals " + mathQuotient);

            //Takes the user input, determines if it is true that it is greater than 50, and writes the result on the console
            userInput = Convert.ToInt16(Console.ReadLine());
            bool trueOrFalse = userInput > 50;
            Console.WriteLine("It is "+ Convert.ToString(trueOrFalse) + " that " + userInput + " is greater than 50");

            //Takes the user input, divides it by 7, and writes the remainder result on the console
            userInput = Convert.ToInt16(Console.ReadLine());
            int mathRemainder = userInput % 7;
            Console.WriteLine("The remainder of "+ userInput + " divided by 7 is " + mathRemainder);

        }
    }
}