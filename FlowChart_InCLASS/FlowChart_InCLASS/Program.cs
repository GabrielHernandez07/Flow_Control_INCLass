using System;

namespace FlowChart_InCLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randValue = rand.Next(1, 101);

            if (randValue % 3 == 0 && randValue % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (randValue % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randValue % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else

            Console.WriteLine(randValue);
        }
    }
}
