using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            string pick;
            string dashes = new string('-', 15);

            Random rng = new Random();

            do
            {
                Console.WriteLine(dashes + "Pick Your Lucky Game" + dashes);
                Console.WriteLine();
                Console.WriteLine("1: Triple Pick");
                Console.WriteLine("2: Quad Pick");
                Console.WriteLine("3: Mega Pick");
                Console.WriteLine("4: End Game");

                pick = Console.ReadLine();

                Console.Clear();

                if (pick == "1")
                {
                    string game = (dashes + "TRIPLE PICK" + dashes);
                    string pick1;
                    string pick2;
                    string pick3;

                    int winner1 = rng.Next(0, 10);
                    int winner2 = rng.Next(0, 10);
                    int winner3 = rng.Next(0, 10);

                    Console.WriteLine(game);
                    Console.WriteLine();

                    Console.WriteLine("For this game, you get to pick THREE numbers between 0-10. " +
                                      "You can pick the same number more than once.");
                    Console.WriteLine("If you match all THREE numbers, in the same order, you win!");
                    Console.WriteLine();
                    Console.WriteLine("Please Pick A Number Between 0-10");
                    pick1 = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine(game);
                    Console.WriteLine();
                    Console.WriteLine("Please Pick Another Number Between 0-10");
                    pick2 = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine(game);
                    Console.WriteLine();
                    Console.WriteLine("Please Pick Your Final Number Between 0-10");
                    pick3 = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine(game);
                    Console.WriteLine();
                    Console.WriteLine("And the winning numbers are....");
                    Console.WriteLine(winner1);
                    Console.WriteLine(winner2);
                    Console.WriteLine(winner3);

                    if (pick1 == winner1.ToString() && pick2 == winner2.ToString() && pick3 == winner3.ToString())
                        Console.WriteLine("YOU WIN!");
                    else
                        Console.WriteLine("Sorry, you didn't win this time.");

                    Console.ReadLine();

                }
            }

            while (pick != "4");

            Console.ReadLine();
        }
    }
}
