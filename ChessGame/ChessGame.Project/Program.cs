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


            string[] rowArray = new string[8] { "1", "2", "3", "4", "5", "6", "7", "8" };
            string[] colArray = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h" };
            int numberOfPositions = new int();
            numberOfPositions = rowArray.Length * colArray.Length;
            string[] positions = new string[numberOfPositions];
            int i = new int();
            i = 0;
            for (int r = 0; r < rowArray.Length; r++)
            {
                for (int c = 0; c < colArray.Length; c++)
                {
                    positions[i++] = rowArray[r]+colArray[c];
                }
            }

            for (int j = 0; j < numberOfPositions; j++)
            {
                Console.WriteLine(positions[j]);
            }
            Console.ReadLine();
            //var piece = Piece.Colour.white;
            //piece.


        }
    }
}
