using Gomoku.Game;
using Gomoku.Players;
using System;

namespace Gomoku
{
    class Program
    {
        public string Name => throw new System.NotImplementedException();

        static void Main(string[] args)
        {
            System.Console.WriteLine("Gomoku!");


            Controller c = new Controller();
           

       /*     Console.WriteLine("Type Player 1 name.");
            new HumanPlayer(Console.ReadLine());
            Console.WriteLine("Type Player 2 name.");
            new HumanPlayer(Console.ReadLine());
*/

            string[,] drawBoard = new string[16, 16];


            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++) 
                { 

                    drawBoard[i, j] = "";

                    
                }
            }

            for (int i = 0; i < 16; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(" ");
                }
                else if (i <= 9)
                {
                    Console.WriteLine($"0{i}");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
                for (int j = 0; j < 16; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (j <= 9)
                    {
                        Console.Write($"0{j}");
                    }
                    else
                    {
                        Console.Write($"{j}");
                    }
                    Console.Write($"{drawBoard[i, j]}_ ");
                }
            }

                Console.WriteLine();
            }

        }



    
}
