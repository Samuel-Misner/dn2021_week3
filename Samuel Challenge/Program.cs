using System;
using System.Collections.Generic;

namespace Samuel_Challenge
{
    class Player
    {
        public int X;
        public int Y;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        static void PrintBoard(int playerX, int playerY, int boardX, int boardY)
        {
            for (int y = 0; y < boardY; y++)
            {
                string line = "";
                for (int x = 0; x < boardX; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        line += "x ";
                    }
                    else
                    {
                        line += "- ";
                    }
                }
                Console.WriteLine(line);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> boardSize = new Dictionary<string, int>();
            boardSize["X"] = 9;
            boardSize["Y"] = 9;
            Player plr = new Player(4, 4);

            PrintBoard(plr.X, plr.Y, boardSize["X"], boardSize["Y"]);
        }
    }
}
