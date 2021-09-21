using System;

namespace LA1200
{
    class Program
    {

        static int getRandom()
        {
            return 42;
        }

        static void Main(string[] args)
        {
            int needle = getRandom();
            Console.WriteLine("I thought of a number. Now you think of yours!");


            // Console.WriteLine("(It's " + needle + ", but don't tell anyone.)");
            int attempts = 0;
            bool isContinue = true;

            while (isContinue == true)
            {
                int guess = Int16.Parse(Console.ReadLine());
                Console.WriteLine("You guessed " + guess);

                if (guess > needle)
                {
                    Console.WriteLine("You're thinking too big! Scale down!");
                    attempts++;
                }

                else if (guess == needle)
                {
                    Console.WriteLine("You got it! It took you " + attempts + " attempts!");
                    isContinue = false;
                }

                else if (guess < needle)
                {
                    Console.WriteLine("You're thinking too small! Size up!");
                    attempts++;
                }
            }

            Console.WriteLine("It was fun playing with you. Hasta luego!");
        }
    }
}
