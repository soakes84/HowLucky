using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HowLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "How Lucky Are You?";

            string pick;
            string quickPick;

            int quickPick1;
            int quickPick2;
            int quickPick3;
            int quickPick4;

            string dashes = new string('-', 15);

            Random rng = new Random();

            do
            {
                Console.WriteLine(dashes + "Pick Your Lucky Game" + dashes);
                Console.WriteLine();
                Console.WriteLine("1: Triple Pick");
                Console.WriteLine("2: Quad Pick");
                Console.WriteLine("3: End Game");

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
                    Console.WriteLine("Enter 1 to pick your own numbers or enter 2 for Quick Pick");
                    quickPick = Console.ReadLine();

                    if(quickPick == "1")
                    {
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
                        Console.WriteLine($"Your numbers are: {pick1}, {pick2}, {pick3}");
                        // Console.WriteLine("Your numbers are: {0}, {1}, {2}", pick1, pick2, pick3);  **same output as line above
                        Console.WriteLine("And the winning numbers are....");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(1000);
                        Console.WriteLine(winner1);
                        Thread.Sleep(1000);
                        Console.WriteLine(winner2);
                        Thread.Sleep(1000);
                        Console.WriteLine(winner3);

                        if (pick1 == winner1.ToString() && pick2 == winner2.ToString() && pick3 == winner3.ToString())
                            YouWin();
                        else
                            YouLose();

                        Console.ReadLine();
                    }

                    else if(quickPick == "2")
                    {
                        quickPick1 = rng.Next(0, 10); 
                        quickPick2 = rng.Next(0, 10);
                        quickPick3 = rng.Next(0, 10);

                        Console.WriteLine(game);
                        Console.WriteLine("You have selected Quick Pick. Your numbers are: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(quickPick1);
                        Thread.Sleep(1000);
                        Console.WriteLine(quickPick2);
                        Thread.Sleep(1000);
                        Console.WriteLine(quickPick3);
                        Console.WriteLine(); 

                        Console.WriteLine("And the winning numbers are....");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(1000);
                        Console.WriteLine(winner1);
                        Thread.Sleep(1000);
                        Console.WriteLine(winner2);
                        Thread.Sleep(1000);
                        Console.WriteLine(winner3);

                        if (quickPick1.ToString() == winner1.ToString() && quickPick2.ToString() == winner2.ToString() && quickPick3.ToString() == winner3.ToString())
                            YouWin();
                        else
                            YouLose();

                        Console.ReadLine();
                    }
                    
                }

                else if (pick == "2")
                {
                    string game = (dashes + "QUAD PICK" + dashes);
                    string pick1;
                    string pick2;
                    string pick3;
                    string pick4;

                    int winner1 = rng.Next(0, 10);
                    int winner2 = rng.Next(0, 10);
                    int winner3 = rng.Next(0, 10);
                    int winner4 = rng.Next(0, 10);

                    Console.WriteLine(game);
                    Console.WriteLine();

                    Console.WriteLine("For this game, you get to pick FOUR numbers between 0-10. " +
                                      "You can pick the same number more than once.");
                    Console.WriteLine("If you match all FOUR numbers, in the same order, you win!");
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
                    Console.WriteLine("Please Pick Another Number Between 0-10");
                    pick3 = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine(game);
                    Console.WriteLine();
                    Console.WriteLine("Please Pick Your Final Number Between 0-10");
                    pick4 = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine(game);
                    Console.WriteLine();
                    Console.WriteLine($"Your numbers are: {pick1}, {pick2}, {pick3}, {pick4}");
                    Console.WriteLine("And the winning numbers are....");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Thread.Sleep(1000);
                    Console.WriteLine(winner1);
                    Thread.Sleep(1000);
                    Console.WriteLine(winner2);
                    Thread.Sleep(1000);
                    Console.WriteLine(winner3);
                    Thread.Sleep(1000);
                    Console.WriteLine(winner4);

                    if (pick1 == winner1.ToString() && pick2 == winner2.ToString() && pick3 == winner3.ToString()
                        && pick4 == winner4.ToString())
                        YouWin();

                    else
                        YouLose();

                    Console.ReadLine();

                }
            }

            while (pick != "3");

            Console.ReadLine();
        }

        static void YouWin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$$$$ You Win $$$$");
            Console.ResetColor();
        }

        static void YouLose()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Sorry, you didn't win this time. \n" +
                "Please hit enter to continue.");
            Console.ResetColor();
        }
    }
}
