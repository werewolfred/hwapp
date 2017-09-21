using System;

namespace hwapp
{
    class Guess
    {
        public void play()
        {
            Console.WriteLine("Pick a number between 1 and 100!");
            Random pickNum = new Random();
            int pick = pickNum.Next(0,100);
            int num = Convert.ToInt32(Console.ReadLine());
            

        }
    }
}