using System;
using System.Threading;

namespace SimpleConsoleGame
{
    class SimpleConsoleGame
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Game Start!");
            new SimpleConsoleGame().GameLoop();
                        
            
        }

        private void GameLoop()
        {
            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Game loop is running");

            }
        }
    }
}
