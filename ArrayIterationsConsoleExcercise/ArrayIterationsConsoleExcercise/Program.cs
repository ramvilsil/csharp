

namespace ArrayIterationsExercise
{
    class Program
    {
        static void Main()
        {

            //Part 1

            string[] stringsArray = { "1: ", "2: ", "3: ", "4: ", "5: " };

            Console.WriteLine("Enter a word: ");

            string word = Console.ReadLine() + "\n";

            for (int i = 0; i < stringsArray.Length; i++)
            {
                stringsArray[i] = stringsArray[i] + word;
            }

            for (int i = 0; i < stringsArray.Length; i++)
            {
                Console.WriteLine(stringsArray[i]);
            }


            //Part 2

            int num = 0;

            bool running = true;

            while (running)
            {
                Console.WriteLine(num + "\n");
               
                num++;

                if (num == 10)
                {
                    running = false;
                }
            }


            //Part 3

            num = 40;

            string outputText = "Hello World! ";

            running = true;

            while (running)
            {
                Console.WriteLine(outputText + num + "\n");

                num--;

                if (num < 20)
                {
                    running = false;
                }
            }


            num = 100;

            outputText = "Goodbye World. ";

            running = true;

            while (running)
            {
                Console.WriteLine(outputText + num + "\n");

                num -= 20;

                if (num <= 20)
                {
                    running = false;
                }
            }


            //Part 4



            

        }

    }
}