using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureFoundationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("DANGANRONPA: FUTURE FOUNDATION");
            Console.WriteLine("1. New Game");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                GameSetup();
            }
        }

        private static void GameSetup()
        {
            Console.Clear();
            Console.Write("Two years ago, the world fell into despair when ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Junko Enoshima");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" brainwashed the students of Hope's Peak Academy and spread her teachings over the world. To restore the world to its rightful state, the Future Foundation was formed.");
            Console.ReadLine();
        }
    }
}
