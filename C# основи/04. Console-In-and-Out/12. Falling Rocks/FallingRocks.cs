using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.Falling_Rocks
{
    class FallingRocks
    {
        static void Main(string[] args)
        {
            // General initialization
            Random rng = new Random();
            int[,] rockPositions = new int[30, 45];
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            int playfield = 40;
            var score = Stopwatch.StartNew();

            // Dwarf 
            int dwarfX = playfield / 2;
            int dwarfY = Console.WindowHeight - 1;
            string dwarfSymbol = "(0)";
            ConsoleColor dwarfColor = ConsoleColor.Green;


            // Game Loop

            bool isGameOver = false;
            while (!isGameOver)
            {
                Console.Clear();
                // key Handler 
                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        //Move character to the left
                        //Check if we left the box 
                        if ( dwarfX - 1 >= 0)
                        {
                            dwarfX -= 2;
                        }
                         
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarfX + 3 < playfield)
                        {
                            dwarfX += 2;
                        }
                    }
                    {

                    }
                }
                // Rocks creation
                int numberOfRocks = rng.Next(1, 5); // #ofRocks
                for (int i = 0; i < numberOfRocks; i++) // Generate 1 rock for a sertain lenght
                {
                    int rockLenght = rng.Next(1, 4);
                    int positionX = rng.Next(0, playfield);
                    for (int j = 0; j < rockLenght; j++)
                    {
                        rockPositions[0, positionX + j] = 1;
                                            }

                }
                // Moving Rocks downwards 
                for (int i = 29; i >= 0; i--)
                {
                    for (int j = 0; j < playfield; j++)
                    {
                        if (rockPositions[i,j] == 1)
                        {
                            rockPositions[i, j] = 0;
                            rockPositions[i + 1, j] = 1;

                        }
                    }
                }
                // Check collitions 
                bool isThereCollisions;
                int counter = 0;
                for (int col = 0; col < playfield; col++)
                {
                    // Dwarf symbol is (0) we need to check 3 positions since 3 positions are reserved to dwarf symbol 
                    bool hasDwarfBeenHit = (dwarfX == col || dwarfX + 1 == col || dwarfX + 2 == col );
                    if (rockPositions[29, col] == 1 && hasDwarfBeenHit)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    isThereCollisions = false;
                }
                else
                {
                    isThereCollisions = true;
                }
                // Print dwarf
                Console.SetCursorPosition(dwarfX, dwarfY);
                Console.ForegroundColor = dwarfColor;
                Console.Write(dwarfSymbol);
                // Print rocks
                for (int row = 0; row < 30; row++)
                {
                    for (int col = 0; col < playfield; col++)
                    {
                        if (rockPositions[row , col] == 1)
                        {
                            Console.SetCursorPosition(col, row); // CHECK - reverse to see result!  (should make rocks move right to left, rather than top to bottom ) 
                            // Console.ForegroundColor = RandomizeColor(rng);
                            Console.Write("{0}", RandomizeRockSymbol(rng));
                        }
                    }
                }

                // Clear Last row
                for (int col = 0; col < playfield; col++)
                {
                    rockPositions[29, col] = 0;

                }
                // Draw UI - Score
                Console.SetCursorPosition(playfield + 1, 3);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Your Score: {0}", score.ElapsedMilliseconds/10);
                // Draw Lines
                for (int row = 0; row < 30; row++)
                {
                    Console.SetCursorPosition(playfield, row);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                }
                // Set SleepTime / Difficulty
                if (score.ElapsedMilliseconds < 20000)
                {
                    Console.SetCursorPosition(playfield + 1, 6);
                    Console.Write("Dificulty:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Easy");
                    Thread.Sleep(250);
                }
                else if (score.ElapsedMilliseconds < 30000)
                {
                    Console.SetCursorPosition(playfield + 1, 6);
                    Console.Write("Dificulty:");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Meduim");
                    Thread.Sleep(150);
                }
                else if (score.ElapsedMilliseconds < 40000)
                {
                    Console.SetCursorPosition(playfield + 1, 6);
                    Console.Write("Dificulty:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Hard");
                    Thread.Sleep(100);
                }
                else if (score.ElapsedMilliseconds < 50000)
                {
                    Console.SetCursorPosition(playfield + 1, 6);
                    Console.Write("Dificulty:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" INSANE!!!");
                    Thread.Sleep(50);
                }

                // Game Over
                if (isThereCollisions)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FAIL!!! \n\n Your Score is: {0} \n\n You are the best Murr! \n\n Press ENTER to exit", score.ElapsedMilliseconds/10);
                    isGameOver = true;

                }
            }
            Console.ReadLine(); // So the console doesn't close! 
            


        }

        private static ConsoleColor RandomizeColor(Random rng)
        {
            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.DarkGreen };
            int randomColorNumber = rng.Next(0, colors.Length);
            return colors[randomColorNumber];
        }

        public static char RandomizeRockSymbol (Random rng)
        {
            char[] rockSymbols = { 'V', 'A', 'S', 'K', 'O', '#', '!', '^', '/', '{', '?', '<', '(', ')' };
            int randomRockNumber = rng.Next(0,rockSymbols.Length);
            return rockSymbols[randomRockNumber];

        }
    }
}
