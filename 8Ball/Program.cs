using System;
using System.Reflection;
using System.Security.Cryptography;

namespace _8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Ask me something?: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string q = Console.ReadLine();

            Random r = new Random();
            int r3 = r.Next(7);
            Console.ForegroundColor = ConsoleColor.Magenta;

            if (r3 == 1)
            {
                Console.WriteLine("That's a stupid question.");
            }
            else if (r3 == 2)
            {
                Console.WriteLine("Uh, ask me later.");
            }
            else if (r3 == 3)
            {
                Console.WriteLine("That's a really smart question.");
            }
            else if (r3 == 4)
            {
                Console.WriteLine("Why you asking me?");
            }
            else if (r3 == 5)
            {
                Console.WriteLine("I don't know");
            }
            else if (r3 == 6)
            {
                Console.WriteLine(q + "! You're not thinking the big picture!");
            }
            else if (r3 == 7)
            {
                Console.WriteLine("If it's a yes or no question then the answer is no.");
            }
            else
            {
                Console.WriteLine("I lost all my money in the crude oil market. That's how I got trapped in this ball.");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
