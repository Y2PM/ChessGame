using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Piece piece1 = new Piece();
            piece1.colour = Piece.Colour.white;
            piece1.name = Piece.Name.pawn;

            Board board = new Board();
            board.PrintPositions();


            #region MyRegion
            //string[] rowArray = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8" };//Make positions on a board.
            //string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };//create the array.
            //int numberOfPositions = new int();
            //numberOfPositions = rowArray.Length * colArray.Length;
            //string[] positions = new string[numberOfPositions];
            //int i = new int();
            //i = 0;//Don't need to set to 0 as it's default value.
            //for (int r = 0; r < rowArray.Length; r++)
            //{
            //    for (int c = 0; c < colArray.Length; c++)
            //    {
            //        positions[i++] = colArray[c] + rowArray[r];
            //    }
            //}



            //int j1 = new int();//Print positions with reversed rows (intuitive layout).
            //for (int j = 7; j > -1; j--)//print the array.
            //{
            //    j1 = 8 * j;
            //    for (int k = 0; k < 8; k++)
            //    {
            //        Console.Write(positions[j1++] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            ///*
            //int j1 = new int();//Print positions.
            //j1 = 0;
            //for (int j = 0; j < 8; j++)
            //{
            //    for (int k = 0; k < 8; k++)
            //    {
            //        Console.Write(positions[j1++] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            //*/ 
            #endregion


        }
    }
}
