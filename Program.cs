using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Can you guess my number?");
            bool Running = true;
            Guess myGuess = new Guess();
            while(Running)
            {
                myGuess.play();
                System.Console.WriteLine("Do you want to try again? (y/n)");
                string Response = Console.ReadLine().ToLower();
                if(Response == "n")
                {
                    Running = false;
                }
            }

        }
    }
}
